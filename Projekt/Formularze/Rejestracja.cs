using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projekt
{
    public partial class Rejestracja : Form
    {
        Logowanie logowanie = new Logowanie();
        public Rejestracja()
        {
            InitializeComponent();
            LoadCaptchaImage();
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            logowanie.Show();
            this.Close();
        }
        int number = 0;
        public void LoadCaptchaImage()
        {
            Random rnd = new Random();
            number = rnd.Next(1000, 10000);
            var image = new Bitmap(this.pbCapcha.Width, this.pbCapcha.Height);
            var font = new Font("TimesNewRoman", 30, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphic = Graphics.FromImage(image);
            graphic.DrawString(number.ToString(), font, Brushes.Black, new Point(100, 0));
            pbCapcha.Image = image;
        }
        public bool IsPasswordValid(string password,string passwordRepeat)
        {
            //sprawdzanie czy hasła nie są puste
            if(password == "" || passwordRepeat == "") {
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

            if (((email == emailP) || (email == emailU)) && (email != "") )
            {
                lbVEmail.Text = "Konto z tym adresem już istnieje";
                return false;
            }
            else if (email != "")
            {
                for (int i = 0; i != email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        return true;
                    }
                    else
                    {
                       lbVEmail.Text = "E-mail nie jest poprawny";
                    }
                }
            }
            else
            {
                lbVEmail.Text = "To pole jest wymagane";
                return false;

            }
            return false;
        }
        public bool IsLoginValid(string login)
        {
            string loginP = "";
            string loginU = "";

            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
            {
                connection.Open();
                string queryU = $"SELECT Login FROM Uzytkownicy WHERE Login = '{login}';"; ;
                string queryP = $"SELECT Login FROM Przewoznicy WHERE Login = '{login}';"; ;

                using (SQLiteCommand command = new SQLiteCommand(queryU, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            loginU = reader["Login"].ToString();
                        }
                    }
                }
                using (SQLiteCommand command = new SQLiteCommand(queryP, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            loginP = reader["Login"].ToString();
                        }
                    }
                }
                connection.Close();
            }

            if (((login == loginP)||(login == loginU))&& (login != ""))
            {
                lbVLogin.Text = "Konto z tym loginem już istnieje";
                return false;
            }
            else if (login != "")
            {
                return true;
            }
            else
            {
                lbVLogin.Text = "To pole jest wymagane";
                return false;
            }
        }

        private void btnUtwoz_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string haslo = tbHaslo.Text;
            string pHaslo = tbPowtorzHaslo.Text;
            string email = tbEmail.Text;
            string rKonta = cbRodzaj.Text;
            string odpowiedz = tbOdpowiedz.Text;


            if (!IsEmailValid(email)){
                IsEmailValid(email);
                lbVEmail.Visible = true;
                lbEmail.ForeColor = Color.Red;
            }
            else
            {
                lbVEmail.Visible = false;
                lbEmail.ForeColor = Color.Black;
            }
            if (!IsPasswordValid(haslo,pHaslo))
            {
                IsPasswordValid(haslo,pHaslo);  
                lbVHaslo.Visible = true;
                lbHaslo.ForeColor = Color.Red;
                lbPHaslo.ForeColor = Color.Red; 
            }
            else
            {
                lbVHaslo.Visible= false;
                lbHaslo.ForeColor= Color.Black;
                lbPHaslo.ForeColor=Color.Black;
            }
            if (!IsLoginValid(login))
            {
                lbVLogin.Visible = true;
                lbLogin.ForeColor = Color.Red;
            }
            else
            {
                lbVLogin.Visible = false;
                lbLogin.ForeColor = Color.Black;
            }
            if(odpowiedz == "")
            {
                lbVOdpowiedz.Visible = true;
                lbVOdpowiedz.Text = "To pole jest wymagane";
                lbOdpowiedz.ForeColor = Color.Red;
            }
            else if(odpowiedz != number.ToString())
            {
                lbVOdpowiedz.Visible = true;
                lbVOdpowiedz.Text = "Błędny kod";
                lbOdpowiedz.ForeColor = Color.Red;
            }
            else 
            {
                lbVOdpowiedz.Visible= false;
                lbOdpowiedz.ForeColor= Color.Black;
            }
            if(rKonta == "")
            {
                lbVRodzaj.Visible = true;
                lbRodzaj.ForeColor = Color.Red;
            }
            else
            {
                lbVRodzaj.Visible= false;
                lbRodzaj.ForeColor = Color.Black;
            }
            if (IsPasswordValid(haslo,pHaslo)&&IsEmailValid(email)&&rKonta!=null&&login!=null&&odpowiedz!=null&&odpowiedz==number.ToString())
            {
                if (rKonta == "Użytkownik")
                { 
                    using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
                    {
                        connection.Open();
                        string query = $"INSERT INTO Uzytkownicy(Email,Login,Haslo) VALUES ('{email}','{login}','{haslo}')";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    logowanie.Show();
                    this.Close();
                }
                else if(rKonta == "Przewoźnik")
                {
                    using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
                    {
                        connection.Open();
                        string query = $"INSERT INTO Przewoznicy(NazwaPrzewoznika, Haslo, Email, Login, IloscLotow) VALUES ('{login}','{haslo}','{email}','{login}',0)";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    logowanie.Show();
                    this.Close();
                }
                
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCaptchaImage();
        }

        private void lbInfo_MouseHover(object sender, MouseEventArgs e)
        {
            
        }

        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            lbInfo.Visible = true;
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            lbInfo.Visible = false;
        }
    }
}
