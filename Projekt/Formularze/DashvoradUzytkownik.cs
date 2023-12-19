using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;

namespace Dashboard_Firmy
{
    public partial class DashboardPrzewoznik : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public DashboardPrzewoznik()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new System.Drawing.Size(7, 60);
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
                leftBorderBtn.Location = new System.Drawing.Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconWybrany.IconChar = currentBtn.IconChar;
                iconWybrany.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
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
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panelWybraneTytul.Text = childForm.Text;
        }

        private void Kontof_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Formularze.Konto_firmowe());
        }

        private void Listal_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Formularze.Lista_lotow());
        }

        private void Dodajl_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Formularze.Dodaj_lot());
        }

        private void Edytujl_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Formularze.Edytuj_lot());
        }

        private void Usunl_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Formularze.Usun_lot());
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconWybrany.IconChar = IconChar.Home;
            iconWybrany.IconColor = System.Drawing.Color.Orange;
            panelWybraneTytul.Text = "Home";
        }
    }
}
