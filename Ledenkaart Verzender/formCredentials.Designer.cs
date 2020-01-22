namespace Ledenkaart_Verzender
{
    partial class FormCredentials
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
            this.components = new System.ComponentModel.Container();
            this.importerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxSmtpServer = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbxSSL = new System.Windows.Forms.CheckBox();
            this.numericSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.importerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSmtpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(132, 33);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(156, 22);
            this.txtBoxEmail.TabIndex = 1;
            // 
            // txtBoxSmtpServer
            // 
            this.txtBoxSmtpServer.Location = new System.Drawing.Point(132, 111);
            this.txtBoxSmtpServer.Name = "txtBoxSmtpServer";
            this.txtBoxSmtpServer.Size = new System.Drawing.Size(156, 22);
            this.txtBoxSmtpServer.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(132, 66);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(156, 22);
            this.txtBoxPassword.TabIndex = 2;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Enabled = false;
            this.ButtonSend.Location = new System.Drawing.Point(189, 257);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSend.Size = new System.Drawing.Size(128, 75);
            this.ButtonSend.TabIndex = 6;
            this.ButtonSend.Text = "OK";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 116);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "SMPT server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 71);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wachtwoord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 151);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "SMTP poort";
            // 
            // chbxSSL
            // 
            this.chbxSSL.AutoSize = true;
            this.chbxSSL.Location = new System.Drawing.Point(132, 185);
            this.chbxSSL.Name = "chbxSSL";
            this.chbxSSL.Size = new System.Drawing.Size(175, 21);
            this.chbxSSL.TabIndex = 5;
            this.chbxSSL.Text = "Secure SSL verbinding";
            this.chbxSSL.UseVisualStyleBackColor = true;
            // 
            // numericSmtpPort
            // 
            this.numericSmtpPort.InterceptArrowKeys = false;
            this.numericSmtpPort.Location = new System.Drawing.Point(132, 151);
            this.numericSmtpPort.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericSmtpPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSmtpPort.Name = "numericSmtpPort";
            this.numericSmtpPort.Size = new System.Drawing.Size(120, 22);
            this.numericSmtpPort.TabIndex = 4;
            this.numericSmtpPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 257);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(134, 75);
            this.button1.TabIndex = 12;
            this.button1.Text = "Test mail versturen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(339, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericSmtpPort);
            this.Controls.Add(this.chbxSSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxSmtpServer);
            this.Controls.Add(this.txtBoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCredentials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verzend instellingen";
            ((System.ComponentModel.ISupportInitialize)(this.importerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSmtpPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource importerBindingSource;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxSmtpServer;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbxSSL;
        private System.Windows.Forms.NumericUpDown numericSmtpPort;
        private System.Windows.Forms.Button button1;
    }
}