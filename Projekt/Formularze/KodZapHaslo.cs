using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class KodZapHaslo : Form
    {
        int kod;
        string LastEmail;
        public KodZapHaslo(int number,string email)
        {
            InitializeComponent();
            LastEmail = email; 
            kod = number;
        }

        private void btnDalej_Click(object sender, EventArgs e)
        {
            if (kod.ToString() == tbKod.Text)
            {
                ResetHasla resetHasla = new ResetHasla(LastEmail);
                resetHasla.Show();
                this.Close();
            }
            else
            {
                lbVEmail.Visible = true;
                lbVEmail.Text = "Wprowadzony kod nie jest poprawny";
                lbEmail.ForeColor = Color.Red; 
            }
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            ZapHaslo zapHaslo = new ZapHaslo();
            zapHaslo.Show();
            this.Close();
        }
    }
}
