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
using System.Windows.Media.Media3D;
using System.Security.Policy;

namespace Projekt
{
    public partial class Dane_konta : Form
    {
        string oldEmail;
        public Dane_konta(string login)
        {
            InitializeComponent();
            ReadDataU(login);
        }
         bool ReadDataU(string login)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
            {
                connection.Open();
                string query = $"SELECT Login, Haslo, Email FROM Uzytkownicy WHERE Login = '{login}'";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emailTextBox.Text = reader.GetString(2);
                            oldEmail = reader.GetString(2);
                            hasloTextBox.Text = reader.GetString(1);
                            loginTextBox.Text = reader.GetString(0);
                        }
                    }
                }
                connection.Close();
            }
            return false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
            {
               
                connection.Open();
                string query = $"UPDATE Uzytkownicy SET Haslo = '{hasloTextBox.Text}', Login = '{loginTextBox.Text}',Email = '{emailTextBox.Text}' WHERE Email = '{oldEmail}';";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    oldEmail = emailTextBox.Text;
                }
                connection.Close();
            }
        }
    }
}

