using System;

namespace FTPUploader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUpload = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtFilePath = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtFTPAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.openFile1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpload.Location = new System.Drawing.Point(146, 224);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(115, 24);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseSelectable = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(292, 185);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Browse...";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtFilePath
            // 
            // 
            // 
            // 
            this.txtFilePath.CustomButton.Image = null;
            this.txtFilePath.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtFilePath.CustomButton.Name = "";
            this.txtFilePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilePath.CustomButton.TabIndex = 1;
            this.txtFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilePath.CustomButton.UseSelectable = true;
            this.txtFilePath.CustomButton.Visible = false;
            this.txtFilePath.Lines = new string[0];
            this.txtFilePath.Location = new System.Drawing.Point(128, 185);
            this.txtFilePath.MaxLength = 32767;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.SelectionLength = 0;
            this.txtFilePath.SelectionStart = 0;
            this.txtFilePath.ShortcutsEnabled = true;
            this.txtFilePath.Size = new System.Drawing.Size(158, 23);
            this.txtFilePath.TabIndex = 12;
            this.txtFilePath.UseSelectable = true;
            this.txtFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilePath.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(128, 145);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(239, 23);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(128, 109);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(239, 23);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // txtFTPAddress
            // 
            // 
            // 
            // 
            this.txtFTPAddress.CustomButton.Image = null;
            this.txtFTPAddress.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtFTPAddress.CustomButton.Name = "";
            this.txtFTPAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFTPAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFTPAddress.CustomButton.TabIndex = 1;
            this.txtFTPAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFTPAddress.CustomButton.UseSelectable = true;
            this.txtFTPAddress.CustomButton.Visible = false;
            this.txtFTPAddress.Lines = new string[] {
        "ftp://"};
            this.txtFTPAddress.Location = new System.Drawing.Point(128, 71);
            this.txtFTPAddress.MaxLength = 32767;
            this.txtFTPAddress.Name = "txtFTPAddress";
            this.txtFTPAddress.PasswordChar = '\0';
            this.txtFTPAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFTPAddress.SelectedText = "";
            this.txtFTPAddress.SelectionLength = 0;
            this.txtFTPAddress.SelectionStart = 0;
            this.txtFTPAddress.ShortcutsEnabled = true;
            this.txtFTPAddress.Size = new System.Drawing.Size(239, 23);
            this.txtFTPAddress.TabIndex = 15;
            this.txtFTPAddress.Text = "ftp://";
            this.txtFTPAddress.UseSelectable = true;
            this.txtFTPAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFTPAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFTPAddress.Click += new System.EventHandler(this.txtFTPAddress_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "FTP Server:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Username:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 149);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Password:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 189);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "File to Upload:";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(412, 270);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtFTPAddress);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FTP Upload :";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MetroFramework.Controls.MetroButton btnUpload;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtFilePath;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtFTPAddress;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.OpenFileDialog openFile1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

