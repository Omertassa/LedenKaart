using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ledenkaart_Verzender
{
    class Sender
    {

        public int CardSender(String email, string password, string smtpServer, int smtpPort, bool SSl)
       
        {
            // send the created membershipCard
            Logger log = new Logger();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            MembershipCard membershipCard = new MembershipCard();

            int numberOfMailsSend;

            numberOfMailsSend = (membershipCard.CreateMembershipCard(email, password, smtpServer, smtpPort, SSl));

            TimeSpan ts = stopWatch.Elapsed;

            log.LogMessageToFile("Het versturen van de mails duurde: " + ts);
            return numberOfMailsSend;
        }


        public bool Testmail(String email, string password, string smtpServer, int smtpPort, bool SSl)

        {
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(email)
                };

                System.Net.Mail.SmtpClient SmtpServer = new SmtpClient(smtpServer)
                {
                    Port = smtpPort,
                    Credentials = new System.Net.NetworkCredential(mail.From.ToString(), password),
                    EnableSsl = SSl
                };

                mail.To.Add(email);
                mail.Subject = "Testmail Ledenkaartverzender";
                mail.Body = "Dit betreft een testbericht.";

                    MessageBox.Show("Proberen verbinding te maken.\nDit kan even duren.","Informatie");

                SmtpServer.Send(mail);

                MessageBox.Show("Testmail is goed verzonden.", "Informatie");
                return true;
            }
            catch {
             
                MessageBox.Show("Kan geen verbinding maken met de email server.\nControleer de gegevens.","Error!");
                return false;
            }

        }

    }
}

