using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Model;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using DevExpress.Pdf;
using System.Drawing.Printing;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Threading;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.CodeParser;
using DxPrintConnector.Models;

namespace DxPrintConnector.PrinterConnector
{


	public partial class FrmMain : DevExpress.XtraEditors.XtraForm
	{
#if (DEBUG)
		private const string host = "https://localhost:7060/";
#else
		private const string host = "https://myapp.com/";
#endif
		private HubConnection _connection = default!;

		private string token = string.Empty;
		private string refreshToken = string.Empty;

		public FrmMain()
		{
			InitializeComponent();

			LoadSettings();
		}

		private async void FrmMain_Load(object sender, EventArgs e)
		{
			layoutControl1.Dock = DockStyle.Fill;
			if (string.IsNullOrEmpty(txtEditPrintID.Text))
				txtEditPrintID.Text = Guid.NewGuid().ToString();

			AddMessage("Installed local printers:");
			foreach (var s in GetPrinters())
			{
				AddMessage($"  [{s}]");
			}
			AddMessage("=========");
			if (string.IsNullOrEmpty(token))
			{
				var dlg = new DlgLogin();
				var result = dlg.ShowDialog(this);
				if (result == DialogResult.OK)
				{
					await Authenticate(dlg.Username, dlg.Password);
				}
			}

			Connect();
		}

		public IEnumerable<string> GetPrinters()
		{
			var result = new List<string>();
			foreach (var s in PrinterSettings.InstalledPrinters)
			{
				result.Add($"{s}");
			}
			return result;
		}

		delegate void SetTextCallback(string[] text);
		private void SetMessage(string[] text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (this.mmoLog.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetMessage);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				this.mmoLog.Lines = text;
			}
		}

		protected void AddMessage(string message)
		{
			List<string> log = new List<string>(mmoLog.Lines) { message };
			SetMessage(log.ToArray());
		}

		protected async Task<bool> Authenticate(string username, string password)
		{
			//TEST PURPOSES!
			if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
				return true;

			AuthenticationModel model = new AuthenticationModel
			{
				Email = username,
				Password = password
			};

			var content = JsonSerializer.Serialize(model);
			var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

			HttpClient _client = new HttpClient();
			var authResult = await _client.PostAsync($"{host}api/accounts/Login", bodyContent);
			var authContent = await authResult.Content.ReadAsStringAsync();
			try
			{
				var result = JsonSerializer.Deserialize<AuthResponseModel>(authContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

				ArgumentNullException.ThrowIfNull(result);

				if (authResult.IsSuccessStatusCode && result.IsAuthSuccessful)
				{
					token = result.Token;
					refreshToken = result.RefreshToken;
					SaveSettings();
				}
				return result.IsAuthSuccessful;
			}
			catch (Exception ex)
			{
				AddMessage($"ERROR: {ex.Message}");
				token = string.Empty;
				refreshToken = string.Empty;
				SaveSettings();
			}
			return false;
		}

		private void LoadSettings()
		{
			token = Properties.Settings.Default.Token;
			refreshToken = Properties.Settings.Default.Refresh;
			txtEditPrintID.Text = Properties.Settings.Default.PrintID;
		}

		private void SaveSettings()
		{
			Properties.Settings.Default.Token = token;
			Properties.Settings.Default.Refresh = refreshToken;
			Properties.Settings.Default.PrintID = txtEditPrintID.Text;
			Properties.Settings.Default.Save();
		}
		protected async Task RefreshToken()
		{
			AddMessage("Requesting token refresh...");
			var tokenModel = JsonSerializer.Serialize(new RefreshModel { Token = token, RefreshToken = refreshToken });
			var bodyContent = new StringContent(tokenModel, Encoding.UTF8, "application/json");

			HttpClient _client = new HttpClient();

			var refreshResult = await _client.PostAsync($"{host}api/token/refresh", bodyContent);
			var refreshContent = await refreshResult.Content.ReadAsStringAsync();
			var result = JsonSerializer.Deserialize<AuthResponseModel>(refreshContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
			if (!refreshResult.IsSuccessStatusCode)
				AddMessage("Something went wrong during the refresh token action");
			else
				AddMessage("Token refresh successfully");
			token = result.Token;
			refreshToken = result.RefreshToken;
			SaveSettings();
		}

		protected async void Connect()
		{
			try
			{
				//await RefreshToken();
				_connection = new HubConnectionBuilder()
					.WithUrl($"{host}printhub?printID={txtEditPrintID.Text}", options =>
					{
						//options.AccessTokenProvider = () => Task.FromResult(token);												
					})
					.WithAutomaticReconnect()
					.Build();

				_connection.Closed += async (error) =>
				{
					await Task.Delay(new Random().Next(0, 5) * 1000);
					await _connection.StartAsync();
				};

				_connection.On<string, PrintPDFArgs>("PrintReceipt",
					async (printID, args) =>
					{
						if (printID == txtEditPrintID.Text && args.OrderID != 0)
							await PrintReceipt(args);
						else
							AddMessage($"ERROR: Invalid print job");
					});

				await _connection.StartAsync();
				txtEditPrintID.ReadOnly = false;
				btnConnect.Checked = true;
				AddMessage("Connected");
				string echoResult = await _connection.InvokeAsync<string>("EchoService", "Check 1-2-3");
				AddMessage(echoResult);
			}
			catch (Exception ex)
			{

				AddMessage($"[ERROR] {ex.Message}");
			}
		}

		protected async Task Disconnect()
		{
			try
			{
				await _connection.StopAsync();
				await _connection.DisposeAsync();
			}
			finally
			{
				btnConnect.Checked = false;
				txtEditPrintID.ReadOnly = true;
				_connection = null;
			}
		}

		protected async Task PrintReceipt(PrintPDFArgs args)
		{
			AddMessage($"Printing order {args.OrderID}");

			if (notifyIcon1.Visible)
			{
				notifyIcon1.BalloonTipTitle = "Order received";
				notifyIcon1.BalloonTipText = $"Printing order {args.OrderID} ";
				notifyIcon1.ShowBalloonTip(4000);
			}

			var model = new PostPDFModel(args.OrderID, args.UserID, args.ReportName);
			var content = JsonSerializer.Serialize(model);
			var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

			HttpClient _client = new HttpClient();
			int retryCount = 0;
			while (retryCount < 4)
			{
				retryCount++;
				if (!string.IsNullOrEmpty(token))
					_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

				var authResult = await _client.PostAsync($"{host}PDF", bodyContent);
				if (authResult.StatusCode == System.Net.HttpStatusCode.Unauthorized /*401*/) //token expired				
				{
					await RefreshToken();
				}
				else if (authResult.StatusCode == System.Net.HttpStatusCode.OK)
				{
					using (var stream = new MemoryStream())
					{
						await authResult.Content.CopyToAsync(stream);
						stream.Position = 0;
						PrintPDFStream(stream, args.Printer, Convert.ToInt16($"{args.Copies}"));
					}
					return;
				}
				else
				{
					Thread.Sleep(3000);
				}
			}
		}

		void PrintPDFStream(Stream stream, string printer, short copies)
		{
			try
			{
				PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
				documentProcessor.LoadDocument(stream, true);

				PdfPrinterSettings pdfPrinterSettings = new PdfPrinterSettings();
				pdfPrinterSettings.PageOrientation = PdfPrintPageOrientation.Portrait;
				//Specify .NET printer settings                
				PrinterSettings settings = pdfPrinterSettings.Settings;
#pragma warning disable CA1416 // Validate platform compatibility
				settings.DefaultPageSettings.Margins.Top = 0;
				settings.DefaultPageSettings.Margins.Left = 0;
				settings.DefaultPageSettings.Margins.Right = 0;
				settings.DefaultPageSettings.Margins.Bottom = 0;
				//settings.CreateMeasurementGraphics(true);
				settings.PrinterName = printer;
				settings.Copies = copies;
#pragma warning restore CA1416 // Validate platform compatibility

				// Print the document using the specified printer settings.
				documentProcessor.Print(pdfPrinterSettings);
			}
			catch (Exception ex)
			{
				AddMessage($"Error printing receipt\n{ex.Message}");
			}
		}

		private void btnConnect_CheckedChanged(object sender, EventArgs e)
		{
		}

		private async void btnConnect_Click(object sender, EventArgs e)
		{
			var btn = sender as CheckButton;
			if (btn != null)
			{
				if (btn.Checked)
				{
					var dlg = new DlgLogin();
					var result = dlg.ShowDialog(this);
					if (result == DialogResult.OK)
					{
						await Authenticate(dlg.Username, dlg.Password);
					}
					Connect();
				}
				else
				{

					await Disconnect();

				}
			}
		}

		private void FrmMain_Resize(object sender, EventArgs e)
		{

			if (this.WindowState == FormWindowState.Minimized)
			{
				Hide();
				notifyIcon1.Visible = true;
			}
		}
		private bool canClose = false;
		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
			notifyIcon1.Visible = false;
		}
		private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem == toolStripExit)
			{
				canClose = true;
				Close();
			}
			else if (e.ClickedItem == toolstripShow)
			{
				Show();
				WindowState = FormWindowState.Normal;
				notifyIcon1.Visible = false;
			}
		}

		private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!canClose && e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				WindowState = FormWindowState.Minimized;
			}
		}

		private void FrmMain_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt && e.KeyCode == Keys.F4) canClose = true;
		}

		private void RegisterInStartup(bool isChecked)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
					("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (isChecked)
			{
				registryKey.SetValue("DxPrintConnector", Application.ExecutablePath);
			}
			else
			{
				registryKey.DeleteValue("DxPrintConnector");
			}
		}

		private void chkAutorun_CheckedChanged(object sender, EventArgs e)
		{
			var ctrl = (sender as CheckEdit);
			if (ctrl != null)
			{
				RegisterInStartup(ctrl.Checked);
			}
		}

		private void txtEditPrintID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			if (e.Button.Index == 0)
			{
				var confirmResult = MessageBox.Show("Are you sure to refresh the PrintID ?\nYou need to refresh it in the portal as well",
									 "Confirm Refresh!!",
									 MessageBoxButtons.YesNo);
				if (confirmResult == DialogResult.Yes)
				{

					txtEditPrintID.Text = Guid.NewGuid().ToString();
					SaveSettings();

				}
			}
			else if (e.Button.Index == 1)
			{
				Clipboard.SetText(txtEditPrintID.Text);
				MessageBox.Show("PrintID is copied to clipboard", "Copied", MessageBoxButtons.OK);
			}
		}
	}
}
