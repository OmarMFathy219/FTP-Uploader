using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace FTPUploader
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uploadFile(string FTPAddress, string filePath, string username, string password)
        {
            //Create FTP request
            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(FTPAddress + "/" + Path.GetFileName(filePath));

            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(username, password);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;

            //Load the file
            FileStream stream = File.OpenRead(filePath);
            byte[] buffer = new byte[stream.Length];

            stream.Read(buffer, 0, buffer.Length);
            stream.Close();

            //Upload file
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(buffer, 0, buffer.Length);
            reqStream.Close();

            MessageBox.Show("Uploaded Successfully");
        }

        private void txtFTPAddress_Leave(object sender, EventArgs e)
        {
            if (!txtFTPAddress.Text.StartsWith("ftp://"))
                txtFTPAddress.Text = "ftp://" + txtFTPAddress.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            btnUpload.Enabled = false;
            Application.DoEvents();

            uploadFile(txtFTPAddress.Text, txtFilePath.Text, txtUsername.Text, txtPassword.Text);
            btnUpload.Enabled = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (openFile1.ShowDialog() == DialogResult.OK)
            {
                MetroFramework.Controls.MetroTextBox txtFilePath1 = txtFilePath;
                txtFilePath1.Text = openFile1.FileName;
            }
        }

        private void txtFTPAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}