using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projekt
{
    public partial class ResetHasla : Form
    {
        string LastEmail;
        public ResetHasla(string email)
        {
            LastEmail = email;
            InitializeComponent();
        }
        public bool IsPasswordValid(string password, string passwordRepeat)
        {
            //sprawdzanie czy hasła nie są puste
            if (password == "" || passwordRepeat == "")
            {
                lbVHaslo.Text = "Te pola są wymagane";
                return false;
            }
            //sprawdzanie czy hasła są takie same
            if (password != passwordRepeat)
            {
                lbVHaslo.Text = "Hasła nie są takie same";
                return false;
            }
            // Sprawdzanie, czy hasło ma co najmniej 8 znaków
            if (password.Length < 8)
            {
                lbVHaslo.Text = "Hasło musi mieć minnimum 8 znaków";
                return false;
            }
            // Sprawdzanie, czy hasło zawiera co najmniej jedną wielką literę
            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                lbVHaslo.Text = "Hasło musi zawierać wielką literę";
                return false;
            }
            // Sprawdzanie, czy hasło zawiera co najmniej jeden znak specjalny
            if (!Regex.IsMatch(password, "[!@#\\$%^&*()_+\\-=\\[\\]{};':\",.<>/?]"))
            {
                lbVHaslo.Text = "Hasło musi zawierać znak specjalny";
                return false;
            }
            // Sprawdzanie, czy hasło zawiera co najmniej jedną cyfrę
            if (!Regex.IsMatch(password, "[0-9]"))
            {
                lbVHaslo.Text = "Hasło musi zawierać cyfrę";
                return false;
            }

            return true;
        }

        private void btnDalej_Click(object sender, EventArgs e)
        {
            string haslo = tbHaslo.Text;
            string pHaslo = tbPHaslo.Text;

            if (!IsPasswordValid(haslo, pHaslo))
            {
                IsPasswordValid(haslo, pHaslo);
                lbVHaslo.Visible = true;
                lbHaslo.ForeColor = Color.Red;
                lbPHaslo.ForeColor = Color.Red;
            }
            else
            {
                lbVHaslo.Visible = false;
                lbHaslo.ForeColor = Color.Black;
                lbPHaslo.ForeColor = Color.Black;

                string emailP = "";
                string emailU = "";

                using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
                {
                    connection.Open();
                    string queryU = $"SELECT Email FROM Uzytkownicy WHERE Email = '{LastEmail}';";
                    string queryP = $"SELECT Email FROM Przewoznicy WHERE Email = '{LastEmail}';";

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
                if (emailP != "")
                {
                    using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
                    {
                        connection.Open();
                        string query = $"UPDATE Przewoznicy SET Haslo = '{haslo}' WHERE Email = '{emailP}';";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
                if(emailU != "")
                {
                    using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
                    {
                        connection.Open();
                        string query = $"UPDATE Uzytkownicy SET Haslo = '{haslo}' WHERE Email = '{emailU}';";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
                Logowanie logowanie = new Logowanie();
                logowanie.Show();
                this.Close();
            }
        }
    }
}
