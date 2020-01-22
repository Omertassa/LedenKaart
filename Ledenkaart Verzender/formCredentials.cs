using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ledenkaart_Verzender
{
    public partial class FormCredentials : Form
    {

        String UserEmail;
        String Password;
        String SmtpServer = "mail.mijndomein.nl";
        int SmtpPort = 587;
        Boolean SSL = true;




        public FormCredentials()
        {

            //String buttonText;
            InitializeComponent();

            txtBoxEmail.Text = UserEmail;
            txtBoxPassword.Text = Password;
            txtBoxSmtpServer.Text = SmtpServer;
            numericSmtpPort.Value = (int)SmtpPort;
            chbxSSL.Checked = SSL;




            //switch (NumberOfMails)
            //{
            //    case 0:
            //        buttonText = "\ngeen mails te versturen";
            //        break;
            //    case 1:
            //        buttonText = "\n mail versturen";
            //        break;
            //    default:
            //        buttonText = "\nmails versturen";
            //        break;
            //}

            //ButtonSend.Text = (NumberOfMails + buttonText);

        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {

            this.Close();
            this.DialogResult = DialogResult.OK;

            Sender sender1 = new Sender();

            sender1.CardSender(UserEmail, Password, SmtpServer, SmtpPort, SSL);

        }



        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                UserEmail = txtBoxEmail.Text;
                Password = txtBoxPassword.Text;
                SmtpServer = txtBoxSmtpServer.Text;
                SmtpPort = (int)numericSmtpPort.Value;
                if (chbxSSL.Checked == true) { SSL = true; } else { SSL = false; }

                if (UserEmail == "" || Password == "" || SmtpServer == "")

                {
                    MessageBox.Show("Er ontbreken belangrijke gegevens.", "Error");
                }

                else
                {

                    if (!IsValidEmail(UserEmail))
                    {

                        MessageBox.Show("Email adres is onjuist");
                    }

                    else
                    {


                        Sender testSender = new Sender();
                        if (testSender.Testmail(UserEmail, Password, SmtpServer, SmtpPort, SSL))
                        {

                            txtBoxEmail.Enabled = false;
                            txtBoxPassword.Enabled = false;
                            txtBoxSmtpServer.Enabled = false;
                            numericSmtpPort.Enabled = false;
                            chbxSSL.Enabled = false;

                            button1.Enabled = false;
                            ButtonSend.Enabled = true;


                        };
                    }
                }

            }
        }
    }
}
