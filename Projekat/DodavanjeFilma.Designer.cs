namespace Projekat
{
    partial class DodavanjeFilma
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNazivFilm = new MetroFramework.Controls.MetroTextBox();
            this.txtOpis = new MetroFramework.Controls.MetroTextBox();
            this.txtZanr = new MetroFramework.Controls.MetroTextBox();
            this.btnDodajFilm = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Naziv filma";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Zanr ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Opis";
            // 
            // txtNazivFilm
            // 
            this.txtNazivFilm.Location = new System.Drawing.Point(124, 67);
            this.txtNazivFilm.Name = "txtNazivFilm";
            this.txtNazivFilm.Size = new System.Drawing.Size(146, 23);
            this.txtNazivFilm.TabIndex = 10;
           
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(124, 115);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(147, 23);
            this.txtOpis.TabIndex = 11;
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(124, 159);
            this.txtZanr.Multiline = true;
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtZanr.Size = new System.Drawing.Size(247, 106);
            this.txtZanr.TabIndex = 12;
            this.txtZanr.TextChanged += new System.EventHandler(this.txtZanr_TextChanged);
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Location = new System.Drawing.Point(22, 212);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(75, 53);
            this.btnDodajFilm.TabIndex = 13;
            this.btnDodajFilm.Text = "Dodaj film";
            // 
            // DodavanjeFilma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 282);
            this.Controls.Add(this.btnDodajFilm);
            this.Controls.Add(this.txtZanr);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNazivFilm);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "DodavanjeFilma";
            this.Text = "DodavanjeFilma";
            this.Load += new System.EventHandler(this.DodavanjeFilma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNazivFilm;
        private MetroFramework.Controls.MetroTextBox txtOpis;
        private MetroFramework.Controls.MetroTextBox txtZanr;
        private MetroFramework.Controls.MetroButton btnDodajFilm;
    }
}