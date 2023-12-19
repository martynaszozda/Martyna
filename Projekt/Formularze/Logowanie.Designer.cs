namespace Projekt
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.linkLZarejestruj = new System.Windows.Forms.LinkLabel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbValidation = new System.Windows.Forms.Label();
            this.linkHaslo = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnZaloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(227)))));
            this.btnZaloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZaloguj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnZaloguj.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaloguj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZaloguj.Location = new System.Drawing.Point(225, 282);
            this.btnZaloguj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(369, 49);
            this.btnZaloguj.TabIndex = 0;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = false;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // linkLZarejestruj
            // 
            this.linkLZarejestruj.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.linkLZarejestruj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.linkLZarejestruj.AutoSize = true;
            this.linkLZarejestruj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLZarejestruj.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLZarejestruj.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.linkLZarejestruj.Location = new System.Drawing.Point(349, 44);
            this.linkLZarejestruj.Name = "linkLZarejestruj";
            this.linkLZarejestruj.Size = new System.Drawing.Size(128, 21);
            this.linkLZarejestruj.TabIndex = 1;
            this.linkLZarejestruj.TabStop = true;
            this.linkLZarejestruj.Text = "Nie masz konta?";
            this.linkLZarejestruj.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLZarejestruj_LinkClicked);
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbLogin.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(227, 87);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(367, 35);
            this.tbLogin.TabIndex = 3;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbHaslo.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHaslo.Location = new System.Drawing.Point(227, 167);
            this.tbHaslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '·';
            this.tbHaslo.Size = new System.Drawing.Size(368, 35);
            this.tbHaslo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(236, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(236, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasło: ";
            // 
            // lbValidation
            // 
            this.lbValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbValidation.Font = new System.Drawing.Font("Lato", 9F);
            this.lbValidation.ForeColor = System.Drawing.Color.Red;
            this.lbValidation.Location = new System.Drawing.Point(116, 226);
            this.lbValidation.Name = "lbValidation";
            this.lbValidation.Size = new System.Drawing.Size(595, 18);
            this.lbValidation.TabIndex = 8;
            this.lbValidation.Text = "Niepoprawne hasło lub niepoprawna nazwa użytkownika";
            this.lbValidation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbValidation.Visible = false;
            // 
            // linkHaslo
            // 
            this.linkHaslo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.linkHaslo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.linkHaslo.AutoSize = true;
            this.linkHaslo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkHaslo.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkHaslo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(92)))), ((int)(((byte)(45)))));
            this.linkHaslo.Location = new System.Drawing.Point(333, 12);
            this.linkHaslo.Name = "linkHaslo";
            this.linkHaslo.Size = new System.Drawing.Size(154, 21);
            this.linkHaslo.TabIndex = 9;
            this.linkHaslo.TabStop = true;
            this.linkHaslo.Text = "Zapomniałeś hasła?";
            this.linkHaslo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHaslo_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-104, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 214);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lato Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(117, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(606, 59);
            this.label5.TabIndex = 14;
            this.label5.Text = "Logowanie";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = global::Projekt.Properties.Resources.OIG_wQoiCHCAr;
            this.pictureBox2.Image = global::Projekt.Properties.Resources.OIG_wQoiCHCAr;
            this.pictureBox2.Location = new System.Drawing.Point(324, -4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbLogin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbValidation);
            this.panel2.Controls.Add(this.btnZaloguj);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbHaslo);
            this.panel2.Location = new System.Drawing.Point(-104, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 522);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.linkLZarejestruj);
            this.panel3.Controls.Add(this.linkHaslo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 366);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 156);
            this.panel3.TabIndex = 10;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System logowania";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.LinkLabel linkLZarejestruj;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbValidation;
        private System.Windows.Forms.LinkLabel linkHaslo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

