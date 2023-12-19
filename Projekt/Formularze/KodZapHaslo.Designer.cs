namespace Projekt
{
    partial class KodZapHaslo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KodZapHaslo));
            this.tbKod = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnDalej = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPowrot = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbVEmail = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKod
            // 
            this.tbKod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbKod.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKod.Location = new System.Drawing.Point(123, 175);
            this.tbKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKod.Name = "tbKod";
            this.tbKod.Size = new System.Drawing.Size(367, 35);
            this.tbKod.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEmail.Location = new System.Drawing.Point(132, 152);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(140, 21);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Podaj kod z maila:";
            // 
            // btnDalej
            // 
            this.btnDalej.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDalej.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(227)))));
            this.btnDalej.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDalej.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDalej.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalej.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDalej.Location = new System.Drawing.Point(123, 260);
            this.btnDalej.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(369, 48);
            this.btnDalej.TabIndex = 0;
            this.btnDalej.Text = "Dalej";
            this.btnDalej.UseVisualStyleBackColor = false;
            this.btnDalej.Click += new System.EventHandler(this.btnDalej_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbVEmail);
            this.panel2.Controls.Add(this.tbKod);
            this.panel2.Controls.Add(this.lbEmail);
            this.panel2.Controls.Add(this.btnDalej);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 346);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnPowrot);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 113);
            this.panel3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(95, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 48);
            this.label3.TabIndex = 19;
            this.label3.Text = "Przywracanie Hasła";
            // 
            // btnPowrot
            // 
            this.btnPowrot.FlatAppearance.BorderSize = 0;
            this.btnPowrot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowrot.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnPowrot.IconColor = System.Drawing.Color.Black;
            this.btnPowrot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPowrot.Location = new System.Drawing.Point(3, 34);
            this.btnPowrot.Margin = new System.Windows.Forms.Padding(4);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(75, 59);
            this.btnPowrot.TabIndex = 15;
            this.btnPowrot.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = global::Projekt.Properties.Resources.OIG_wQoiCHCAr;
            this.pictureBox2.Image = global::Projekt.Properties.Resources.OIG_wQoiCHCAr;
            this.pictureBox2.Location = new System.Drawing.Point(500, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // lbVEmail
            // 
            this.lbVEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbVEmail.Font = new System.Drawing.Font("Lato", 9F);
            this.lbVEmail.ForeColor = System.Drawing.Color.Red;
            this.lbVEmail.Location = new System.Drawing.Point(123, 212);
            this.lbVEmail.Name = "lbVEmail";
            this.lbVEmail.Size = new System.Drawing.Size(367, 18);
            this.lbVEmail.TabIndex = 10;
            this.lbVEmail.Text = "Podany kod jest nie prawidłowy";
            this.lbVEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbVEmail.Visible = false;
            // 
            // KodZapHaslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 346);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KodZapHaslo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Hasła";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnDalej;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbVEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnPowrot;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}