namespace DxPrintConnector.PrinterConnector
{
	partial class FrmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			chkAutorun = new DevExpress.XtraEditors.CheckEdit();
			btnConnect = new DevExpress.XtraEditors.CheckButton();
			mmoLog = new DevExpress.XtraEditors.MemoEdit();
			txtEditPrintID = new DevExpress.XtraEditors.ButtonEdit();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutPrintID = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
			contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
			toolstripShow = new System.Windows.Forms.ToolStripMenuItem();
			sep = new System.Windows.Forms.ToolStripSeparator();
			toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)chkAutorun.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)mmoLog.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txtEditPrintID.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutPrintID).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			contextMenuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(chkAutorun);
			layoutControl1.Controls.Add(btnConnect);
			layoutControl1.Controls.Add(mmoLog);
			layoutControl1.Controls.Add(txtEditPrintID);
			layoutControl1.Location = new System.Drawing.Point(87, 78);
			layoutControl1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2415, 507, 650, 605);
			layoutControl1.Root = Root;
			layoutControl1.Size = new System.Drawing.Size(1122, 486);
			layoutControl1.TabIndex = 0;
			layoutControl1.Text = "layoutControl1";
			// 
			// chkAutorun
			// 
			chkAutorun.Location = new System.Drawing.Point(51, 161);
			chkAutorun.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			chkAutorun.Name = "chkAutorun";
			chkAutorun.Properties.Caption = "Run the connector at windows startup";
			chkAutorun.Size = new System.Drawing.Size(855, 44);
			chkAutorun.StyleController = layoutControl1;
			chkAutorun.TabIndex = 7;
			chkAutorun.CheckedChanged += chkAutorun_CheckedChanged;
			// 
			// btnConnect
			// 
			btnConnect.Location = new System.Drawing.Point(914, 99);
			btnConnect.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			btnConnect.Name = "btnConnect";
			btnConnect.Size = new System.Drawing.Size(157, 49);
			btnConnect.StyleController = layoutControl1;
			btnConnect.TabIndex = 6;
			btnConnect.Text = "Connect";
			btnConnect.CheckedChanged += btnConnect_CheckedChanged;
			btnConnect.Click += btnConnect_Click;
			// 
			// mmoLog
			// 
			mmoLog.Location = new System.Drawing.Point(51, 312);
			mmoLog.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			mmoLog.Name = "mmoLog";
			mmoLog.Properties.ReadOnly = true;
			mmoLog.Size = new System.Drawing.Size(1020, 122);
			mmoLog.StyleController = layoutControl1;
			mmoLog.TabIndex = 5;
			// 
			// txtEditPrintID
			// 
			txtEditPrintID.Location = new System.Drawing.Point(158, 99);
			txtEditPrintID.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			txtEditPrintID.Name = "txtEditPrintID";
			editorButtonImageOptions1.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions1.SvgImage");
			editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
			editorButtonImageOptions2.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions2.SvgImage");
			editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(16, 16);
			txtEditPrintID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default), new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
			txtEditPrintID.Size = new System.Drawing.Size(748, 54);
			txtEditPrintID.StyleController = layoutControl1;
			txtEditPrintID.TabIndex = 2;
			txtEditPrintID.ButtonClick += txtEditPrintID_ButtonClick;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1, layoutControlGroup2 });
			Root.Name = "Root";
			Root.Size = new System.Drawing.Size(1122, 486);
			Root.TextVisible = false;
			// 
			// layoutControlGroup1
			// 
			layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2 });
			layoutControlGroup1.Location = new System.Drawing.Point(0, 213);
			layoutControlGroup1.Name = "layoutControlGroup1";
			layoutControlGroup1.Size = new System.Drawing.Size(1078, 229);
			layoutControlGroup1.Text = "Messages";
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = mmoLog;
			layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new System.Drawing.Size(1028, 130);
			layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			layoutControlItem2.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutPrintID, layoutControlItem1, layoutControlItem3 });
			layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			layoutControlGroup2.Name = "layoutControlGroup2";
			layoutControlGroup2.Size = new System.Drawing.Size(1078, 213);
			layoutControlGroup2.Text = "Connection settings";
			// 
			// layoutPrintID
			// 
			layoutPrintID.Control = txtEditPrintID;
			layoutPrintID.Location = new System.Drawing.Point(0, 0);
			layoutPrintID.Name = "layoutPrintID";
			layoutPrintID.Size = new System.Drawing.Size(863, 62);
			layoutPrintID.Text = "Print ID";
			layoutPrintID.TextSize = new System.Drawing.Size(81, 29);
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = btnConnect;
			layoutControlItem1.Location = new System.Drawing.Point(863, 0);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new System.Drawing.Size(165, 114);
			layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = chkAutorun;
			layoutControlItem3.Location = new System.Drawing.Point(0, 62);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new System.Drawing.Size(863, 52);
			layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			layoutControlItem3.TextVisible = false;
			// 
			// notifyIcon1
			// 
			notifyIcon1.ContextMenuStrip = contextMenuStrip1;
			notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
			notifyIcon1.Text = "KwikEat Print Connector";
			notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
			contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolstripShow, sep, toolStripExit });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new System.Drawing.Size(160, 98);
			contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
			// 
			// toolstripShow
			// 
			toolstripShow.Name = "toolstripShow";
			toolstripShow.Size = new System.Drawing.Size(159, 44);
			toolstripShow.Text = "Show";
			// 
			// sep
			// 
			sep.Name = "sep";
			sep.Size = new System.Drawing.Size(156, 6);
			// 
			// toolStripExit
			// 
			toolStripExit.Name = "toolStripExit";
			toolStripExit.Size = new System.Drawing.Size(159, 44);
			toolStripExit.Text = "Exit";
			// 
			// FrmMain
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1369, 620);
			Controls.Add(layoutControl1);
			IconOptions.Image = (System.Drawing.Image)resources.GetObject("FrmMain.IconOptions.Image");
			Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			Name = "FrmMain";
			Text = "PrinterConnector";
			FormClosing += FrmMain_FormClosing;
			Load += FrmMain_Load;
			KeyDown += FrmMain_KeyDown;
			Resize += FrmMain_Resize;
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)chkAutorun.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)mmoLog.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txtEditPrintID.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutPrintID).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			contextMenuStrip1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.ButtonEdit txtEditPrintID;
		private DevExpress.XtraLayout.LayoutControlItem layoutPrintID;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraEditors.MemoEdit mmoLog;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.CheckButton btnConnect;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolstripShow;
		private System.Windows.Forms.ToolStripSeparator sep;
		private System.Windows.Forms.ToolStripMenuItem toolStripExit;
		private DevExpress.XtraEditors.CheckEdit chkAutorun;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
	}
}

