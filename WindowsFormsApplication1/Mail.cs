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
        string allConnections;

        public Mail(string Connections)
        {
            InitializeComponent();
            allConnections = Connections;
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
            try
            {
                //Mail mit Sender und Empfänger initialisieren
                MailMessage mail = new MailMessage(txtAn.Text, txtAn.Text);
                //SmtpClient initisalisier
                SmtpClient smtp = new SmtpClient();
                //dem SmtpClient hinzufügen
                smtp.Credentials = new NetworkCredential(txtVon.Text, txtPasswort.Text);
                //Einstellungen konfigurieren
                smtp.Port = 587;                 
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;                
                mail.IsBodyHtml = true;
                //Nachricht des Mails hinzufügen
                mail.Body = txtNachricht.Text + Environment.NewLine + Environment.NewLine + allConnections;
                //Betreff hinzufügen
                mail.Subject = txtBetreff.Text;
                //Mail senden
                smtp.Send(mail);

                MessageBox.Show("Mail erfolgreich versendet!");

                this.Close();
            }            
            catch(Exception ex)
            {
                MessageBox.Show("Mail konnte nicht versendet werden." + ex);
            }            
        }
    }
}
