using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class SkyFind : Form
    {
        public SkyFind()
        {
            InitializeComponent();
        }

        private void loading_Tick(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
            this.Hide();

            loading.Enabled = false;
        }
    }
}
