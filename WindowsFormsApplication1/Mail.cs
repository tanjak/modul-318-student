using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Mail : Form
    {
        List<string> allConnections;

        public Mail(List<string> Connections)
        {
            InitializeComponent();
            allConnections = Connections;
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress(txtVon.Text);
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(txtVon.Text, txtPasswort.Text);
                smtp.Host = "smtp.gmail.com";
                mail.To.Add(new MailAddress(txtAn.Text));
                mainForm form = new mainForm();
                mail.Body = txtNachricht.Text + Environment.NewLine + Environment.NewLine;
                foreach (var connection in allConnections)
                {
                    mail.Body = mail.Body + connection;
                }

                mail.Subject = txtBetreff.Text;
                smtp.Send(mail);

                MessageBox.Show("Mail erfolgreich versendet!");

                this.Close();
            }            
            catch
            {
                MessageBox.Show("Mail konnte nicht versendet werden. Überprüfen Sie die eingegebenen Daten.");
            }            
        }
    }
}
