using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Web.UI.WebControls;
using System.Security.Policy;

namespace Projekt
{
    public partial class ZapHaslo : Form
    {
        public ZapHaslo()
        {
            InitializeComponent();
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
            this.Close();
        }
        public bool IsEmailValid(string email)
        {
            string emailP = "";
            string emailU = "";
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
            {
                connection.Open();
                string queryU = $"SELECT Email FROM Uzytkownicy WHERE Email = '{email}';";
                string queryP = $"SELECT Email FROM Przewoznicy WHERE Email = '{email}';";

                using (SQLiteCommand command = new SQLiteCommand(queryU, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            emailU = reader["Email"].ToString();
                        }
                    }
                }
                using (SQLiteCommand command = new SQLiteCommand(queryP, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            emailP = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            if (((email == emailP) || (email == emailU)) && (email != ""))
            { 
                return true;
            }
            else if (email != "")
            {
                 lbVEmail.Text = "konto z takim adresem nie istnieje";
                return false;
            }
            else
            {
                lbVEmail.Text = "To pole jest wymagane";
                return false;

            }
        }
        int number;
        public void SendMail(string email,string login)
        {
            string fromMail = "SkyFind.rejestracja@gmail.com";
            string fromPassword = "ixjg gpdq nugc zaln";
            string toMail = email;
            string toLogin = login;
            Random rnd = new Random();
            number = rnd.Next(1000, 10000);
            Console.WriteLine(number);

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Reset Hasła";
            message.To.Add(new MailAddress(toMail));
            message.Body = $"Wtaj {toLogin},<br> Twój kod do edycji hasła to: <b>{number}</b><br>Ta wiadomość została wygenerowana automatycznie";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }
        private void btnDalej_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            if (!IsEmailValid(email))
            {
                IsEmailValid(email);
                lbVEmail.Visible = true;
                lbEmail.ForeColor = Color.Red;
            }
            else
            {
                lbVEmail.Visible = false;
                lbEmail.ForeColor = Color.Black;
                string loginU = "";
                string loginP = "";

                using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
                {
                    connection.Open();
                    string queryU = $"SELECT Login FROM Uzytkownicy WHERE Email = '{email}';";
                    string queryP = $"SELECT Login FROM Przewoznicy WHERE Email = '{email}';";

                    using (SQLiteCommand command = new SQLiteCommand(queryU, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            { 
                                loginU = reader["Login"].ToString();
                            }
                        }
                    }
                    using (SQLiteCommand command = new SQLiteCommand(queryP, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                loginP = reader["Login"].ToString();
                            }
                        }
                    }
                    connection.Close();
                }
                string login = loginP + loginU;
                SendMail(email,login);
                KodZapHaslo kodZapHaslo = new KodZapHaslo(number,email);
                kodZapHaslo.Show();
                this.Close();
            }
        }
    }
}
