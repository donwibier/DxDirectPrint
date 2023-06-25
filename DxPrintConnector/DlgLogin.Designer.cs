namespace DxPrintConnector.PrinterConnector
{
	partial class DlgLogin
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
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutUsername = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutPassword = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtUsername = new DevExpress.XtraEditors.TextEdit();
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutUsername)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.simpleButton2);
			this.layoutControl1.Controls.Add(this.simpleButton1);
			this.layoutControl1.Controls.Add(this.txtUsername);
			this.layoutControl1.Controls.Add(this.txtPassword);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2693, 97, 887, 1164);
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(548, 137);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(548, 137);
			this.Root.TextVisible = false;
			// 
			// layoutUsername
			// 
			this.layoutUsername.Location = new System.Drawing.Point(0, 0);
			this.layoutUsername.Name = "layoutUsername";
			this.layoutUsername.Size = new System.Drawing.Size(343, 24);
			this.layoutUsername.Text = "Username";
			this.layoutUsername.TextSize = new System.Drawing.Size(48, 13);
			// 
			// layoutPassword
			// 
			this.layoutPassword.Location = new System.Drawing.Point(0, 24);
			this.layoutPassword.Name = "layoutPassword";
			this.layoutPassword.Size = new System.Drawing.Size(343, 24);
			this.layoutPassword.Text = "Password";
			this.layoutPassword.TextSize = new System.Drawing.Size(48, 13);
			// 
			// txtUsername
			// 
			this.txtUsername.EditValue = "";
			this.txtUsername.Location = new System.Drawing.Point(75, 15);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(458, 20);
			this.txtUsername.StyleController = this.layoutControl1;
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(75, 45);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.UseSystemPasswordChar = true;
			this.txtPassword.Size = new System.Drawing.Size(458, 20);
			this.txtPassword.StyleController = this.layoutControl1;
			this.txtPassword.TabIndex = 2;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtPassword;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 30);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			this.layoutControlItem1.Size = new System.Drawing.Size(528, 30);
			this.layoutControlItem1.Text = "Password";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtUsername;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			this.layoutControlItem2.Size = new System.Drawing.Size(528, 30);
			this.layoutControlItem2.Text = "Username";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 13);
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 60);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
			this.layoutControlGroup1.Size = new System.Drawing.Size(528, 57);
			this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			// 
			// simpleButton1
			// 
			this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.simpleButton1.Location = new System.Drawing.Point(343, 102);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(90, 20);
			this.simpleButton1.StyleController = this.layoutControl1;
			this.simpleButton1.TabIndex = 3;
			this.simpleButton1.Text = "OK";
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
			this.layoutControlItem3.Control = this.simpleButton1;
			this.layoutControlItem3.Location = new System.Drawing.Point(328, 0);
			this.layoutControlItem3.MaxSize = new System.Drawing.Size(100, 30);
			this.layoutControlItem3.MinSize = new System.Drawing.Size(100, 30);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			this.layoutControlItem3.Size = new System.Drawing.Size(100, 57);
			this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// simpleButton2
			// 
			this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.simpleButton2.Location = new System.Drawing.Point(443, 102);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(90, 20);
			this.simpleButton2.StyleController = this.layoutControl1;
			this.simpleButton2.TabIndex = 4;
			this.simpleButton2.Text = "Cancel";
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
			this.layoutControlItem4.Control = this.simpleButton2;
			this.layoutControlItem4.Location = new System.Drawing.Point(428, 0);
			this.layoutControlItem4.MaxSize = new System.Drawing.Size(100, 30);
			this.layoutControlItem4.MinSize = new System.Drawing.Size(100, 30);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
			this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			this.layoutControlItem4.Size = new System.Drawing.Size(100, 57);
			this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(528, 60);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(328, 57);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// DlgLogin
			// 
			this.AcceptButton = this.simpleButton1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.simpleButton2;
			this.ClientSize = new System.Drawing.Size(548, 137);
			this.Controls.Add(this.layoutControl1);
			this.MaximizeBox = false;
			this.MdiChildrenMinimizedAnchorBottom = false;
			this.MinimizeBox = false;
			this.Name = "DlgLogin";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "KwikEat PrintConnector - Login";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutUsername)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutUsername;
		private DevExpress.XtraLayout.LayoutControlItem layoutPassword;
		private DevExpress.XtraEditors.TextEdit txtUsername;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.TextEdit txtPassword;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}