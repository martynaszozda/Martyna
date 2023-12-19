using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.Formularze;

namespace Projekt.Formularze
{
    public partial class DashboardUzytkownik : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        string personLogin;
        //Constructor
        public DashboardUzytkownik(string login)
        {
            personLogin = login;
            InitializeComponent();
            this.Text = $"Witaj, {personLogin}";
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(0, 118, 227);
        }
        private void ActiveButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new System.Drawing.Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconWybrany.IconChar = currentBtn.IconChar;
                iconWybrany.IconColor = color;

               
            }
        }
            private void DisableButton()
            {
                if (currentBtn != null)
                {
                    currentBtn.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    currentBtn.ForeColor = System.Drawing.Color.Black;
                    currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentBtn.IconColor = System.Drawing.Color.Orange;
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panelWybraneTytul.Text = childForm.Text;
        }
        private void WyszukajL_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Wyszukaj_lot());
        }

        private void DaneK_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Dane_konta(personLogin));
        }

        private void MojeB_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Moje_bilety());
        }

        private void UlubioneL_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Ulubione());
        }
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();

        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconWybrany.IconChar = IconChar.Home;
            iconWybrany.IconColor = Color.Orange;
            panelWybraneTytul.Text = "Home";
        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
            this.Close();
        }
    }    
}
