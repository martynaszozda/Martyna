namespace Projekt
{
    partial class ResetHasla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetHasla));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbPHaslo = new System.Windows.Forms.TextBox();
            this.lbPHaslo = new System.Windows.Forms.Label();
            this.btnDalej = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.lbHaslo = new System.Windows.Forms.Label();
            this.lbVHaslo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 113);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(64, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 48);
            this.label3.TabIndex = 19;
            this.label3.Text = "Przywracanie Hasła";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = global::Projekt.Properties.Resources.OIG_wQoiCHCAr;
            this.pictureBox2.Image = global::Projekt.Properties.Resources.OIG_wQoiCHCAr;
            this.pictureBox2.Location = new System.Drawing.Point(466, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // tbPHaslo
            // 
            this.tbPHaslo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPHaslo.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPHaslo.Location = new System.Drawing.Point(124, 255);
            this.tbPHaslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPHaslo.Name = "tbPHaslo";
            this.tbPHaslo.PasswordChar = '·';
            this.tbPHaslo.Size = new System.Drawing.Size(367, 35);
            this.tbPHaslo.TabIndex = 3;
            // 
            // lbPHaslo
            // 
            this.lbPHaslo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPHaslo.AutoSize = true;
            this.lbPHaslo.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPHaslo.Location = new System.Drawing.Point(133, 232);
            this.lbPHaslo.Name = "lbPHaslo";
            this.lbPHaslo.Size = new System.Drawing.Size(122, 21);
            this.lbPHaslo.TabIndex = 5;
            this.lbPHaslo.Text = "Powtórz Hasło:";
            // 
            // btnDalej
            // 
            this.btnDalej.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDalej.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(227)))));
            this.btnDalej.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDalej.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDalej.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalej.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDalej.Location = new System.Drawing.Point(123, 361);
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
            this.panel2.Controls.Add(this.tbHaslo);
            this.panel2.Controls.Add(this.lbHaslo);
            this.panel2.Controls.Add(this.lbVHaslo);
            this.panel2.Controls.Add(this.tbPHaslo);
            this.panel2.Controls.Add(this.lbPHaslo);
            this.panel2.Controls.Add(this.btnDalej);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 463);
            this.panel2.TabIndex = 18;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbHaslo.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHaslo.Location = new System.Drawing.Point(125, 170);
            this.tbHaslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '·';
            this.tbHaslo.Size = new System.Drawing.Size(367, 35);
            this.tbHaslo.TabIndex = 11;
            // 
            // lbHaslo
            // 
            this.lbHaslo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHaslo.AutoSize = true;
            this.lbHaslo.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHaslo.Location = new System.Drawing.Point(134, 147);
            this.lbHaslo.Name = "lbHaslo";
            this.lbHaslo.Size = new System.Drawing.Size(104, 21);
            this.lbHaslo.TabIndex = 12;
            this.lbHaslo.Text = "Nowe Hasło:";
            // 
            // lbVHaslo
            // 
            this.lbVHaslo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbVHaslo.Font = new System.Drawing.Font("Lato", 9F);
            this.lbVHaslo.ForeColor = System.Drawing.Color.Red;
            this.lbVHaslo.Location = new System.Drawing.Point(124, 292);
            this.lbVHaslo.Name = "lbVHaslo";
            this.lbVHaslo.Size = new System.Drawing.Size(368, 18);
            this.lbVHaslo.TabIndex = 10;
            this.lbVHaslo.Text = "To pole jest wymagane";
            this.lbVHaslo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbVHaslo.Visible = false;
            // 
            // ResetHasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetHasla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Hasła";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPHaslo;
        private System.Windows.Forms.Label lbPHaslo;
        private System.Windows.Forms.Button btnDalej;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbVHaslo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label lbHaslo;
    }
}