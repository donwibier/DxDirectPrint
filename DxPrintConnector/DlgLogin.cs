using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DxPrintConnector.PrinterConnector
{
	public partial class DlgLogin : DevExpress.XtraEditors.XtraForm
	{
		public DlgLogin()
		{
			InitializeComponent();
		}

		public string Username {  get => txtUsername.Text; set => txtUsername.Text = value;}
		public string Password { get => txtPassword.Text; }
	}
}