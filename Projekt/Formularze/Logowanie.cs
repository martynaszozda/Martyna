using Dashboard_Firmy;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.Formularze;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projekt
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }
        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            string haslo = tbHaslo.Text;
            string login = tbLogin.Text;

            bool walidacjaU  = ReadDataU(haslo,login);
            bool walidacjaP = ReadDataP(haslo, login);

            if (walidacjaP) { 
               
                lbValidation.Visible = false;
                DashboardPrzewoznik dashboard = new DashboardPrzewoznik(login);
                dashboard.Show();  
                this.Close();
            }
            else if (walidacjaU)
            {
                lbValidation.Visible = false;
                DashboardUzytkownik dashboard = new DashboardUzytkownik(login);
                dashboard.Show();
                this.Close();
            }
            else
            {
                lbValidation.Visible = true;
            }
        }
        private void linkHaslo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ZapHaslo zapHaslo = new ZapHaslo();
            zapHaslo.Show();
            this.Close();
        }

        private void linkLZarejestruj_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rejestracja rejestracja = new Rejestracja();
            rejestracja.Show();
            this.Close();
        }
        static bool ReadDataU(string haslo, string login)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
            {
                connection.Open();
                string query = $"SELECT Login, Haslo FROM Uzytkownicy WHERE Haslo = '{haslo}' AND Login = '{login}'";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                    }
                }
                connection.Close();
            }
            return false;
        }
        static bool ReadDataP(string haslo, string login)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
            {
                connection.Open();
                string query = $"SELECT Login, Haslo FROM Przewoznicy WHERE Haslo = '{haslo}' AND Login = '{login}'";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                    }
                }
                connection.Close();
            }
            return false;
        }
       
    }
}
