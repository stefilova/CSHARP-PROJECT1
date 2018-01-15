namespace Projekat
{
    partial class Admin
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
            this.btnFilmDodaj = new System.Windows.Forms.Button();
            this.btnFilmIzbrisi = new System.Windows.Forms.Button();
            this.btnFilmDet = new System.Windows.Forms.Button();
            this.lstBoxF = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSizbrisi = new System.Windows.Forms.Button();
            this.btnSDodaj = new System.Windows.Forms.Button();
            this.lstSale = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstKarte = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKarte = new System.Windows.Forms.Button();
            this.txtKarte = new System.Windows.Forms.TextBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.cmbSale = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lstProj = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbSP = new System.Windows.Forms.ComboBox();
            this.cmbFP = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFilmDodaj
            // 
            this.btnFilmDodaj.Location = new System.Drawing.Point(10, 204);
            this.btnFilmDodaj.Name = "btnFilmDodaj";
            this.btnFilmDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnFilmDodaj.TabIndex = 1;
            this.btnFilmDodaj.Text = "Dodaj";
            this.btnFilmDodaj.UseVisualStyleBackColor = true;
            this.btnFilmDodaj.Click += new System.EventHandler(this.btnFilmDodaj_Click);
            // 
            // btnFilmIzbrisi
            // 
            this.btnFilmIzbrisi.Location = new System.Drawing.Point(91, 204);
            this.btnFilmIzbrisi.Name = "btnFilmIzbrisi";
            this.btnFilmIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnFilmIzbrisi.TabIndex = 2;
            this.btnFilmIzbrisi.Text = "Izbrisi";
            this.btnFilmIzbrisi.UseVisualStyleBackColor = true;
            this.btnFilmIzbrisi.Click += new System.EventHandler(this.btnFilmIzbrisi_Click);
            // 
            // btnFilmDet
            // 
            this.btnFilmDet.Location = new System.Drawing.Point(172, 204);
            this.btnFilmDet.Name = "btnFilmDet";
            this.btnFilmDet.Size = new System.Drawing.Size(75, 23);
            this.btnFilmDet.TabIndex = 3;
            this.btnFilmDet.Text = "Detalji";
            this.btnFilmDet.UseVisualStyleBackColor = true;
            this.btnFilmDet.Click += new System.EventHandler(this.btnFilmDet_Click);
            // 
            // lstBoxF
            // 
            this.lstBoxF.FormattingEnabled = true;
            this.lstBoxF.Location = new System.Drawing.Point(10, 6);
            this.lstBoxF.Name = "lstBoxF";
            this.lstBoxF.Size = new System.Drawing.Size(241, 173);
            this.lstBoxF.TabIndex = 4;
            this.lstBoxF.SelectedIndexChanged += new System.EventHandler(this.lstBoxF_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(23, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 292);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstBoxF);
            this.tabPage1.Controls.Add(this.btnFilmDodaj);
            this.tabPage1.Controls.Add(this.btnFilmIzbrisi);
            this.tabPage1.Controls.Add(this.btnFilmDet);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(339, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Azuriraj filmove";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSizbrisi);
            this.tabPage2.Controls.Add(this.btnSDodaj);
            this.tabPage2.Controls.Add(this.lstSale);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(339, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Azuriraj sale";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSizbrisi
            // 
            this.btnSizbrisi.Location = new System.Drawing.Point(88, 227);
            this.btnSizbrisi.Name = "btnSizbrisi";
            this.btnSizbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnSizbrisi.TabIndex = 2;
            this.btnSizbrisi.Text = "Izbrisi";
            this.btnSizbrisi.UseVisualStyleBackColor = true;
            this.btnSizbrisi.Click += new System.EventHandler(this.btnSizbrisi_Click);
            // 
            // btnSDodaj
            // 
            this.btnSDodaj.Location = new System.Drawing.Point(7, 227);
            this.btnSDodaj.Name = "btnSDodaj";
            this.btnSDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnSDodaj.TabIndex = 1;
            this.btnSDodaj.Text = "Dodaj ";
            this.btnSDodaj.UseVisualStyleBackColor = true;
            this.btnSDodaj.Click += new System.EventHandler(this.btnSDodaj_Click);
            // 
            // lstSale
            // 
            this.lstSale.FormattingEnabled = true;
            this.lstSale.Location = new System.Drawing.Point(3, 24);
            this.lstSale.Name = "lstSale";
            this.lstSale.Size = new System.Drawing.Size(247, 186);
            this.lstSale.TabIndex = 0;
            this.lstSale.SelectedIndexChanged += new System.EventHandler(this.lstSale_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstKarte);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnKarte);
            this.tabPage3.Controls.Add(this.txtKarte);
            this.tabPage3.Controls.Add(this.cmbFilm);
            this.tabPage3.Controls.Add(this.cmbSale);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(339, 266);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Azuriraj karte";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstKarte
            // 
            this.lstKarte.FormattingEnabled = true;
            this.lstKarte.Location = new System.Drawing.Point(6, 132);
            this.lstKarte.Name = "lstKarte";
            this.lstKarte.Size = new System.Drawing.Size(244, 121);
            this.lstKarte.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena karte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Izaberi salu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Izaberi film";
            // 
            // btnKarte
            // 
            this.btnKarte.Location = new System.Drawing.Point(169, 103);
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.Size = new System.Drawing.Size(75, 23);
            this.btnKarte.TabIndex = 3;
            this.btnKarte.Text = "OK";
            this.btnKarte.UseVisualStyleBackColor = true;
            this.btnKarte.Click += new System.EventHandler(this.btnKarte_Click);
            // 
            // txtKarte
            // 
            this.txtKarte.Location = new System.Drawing.Point(17, 105);
            this.txtKarte.Name = "txtKarte";
            this.txtKarte.Size = new System.Drawing.Size(121, 20);
            this.txtKarte.TabIndex = 2;
            this.txtKarte.TextChanged += new System.EventHandler(this.txtKarte_TextChanged);
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(17, 49);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(121, 21);
            this.cmbFilm.TabIndex = 1;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            // 
            // cmbSale
            // 
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(169, 49);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(121, 21);
            this.cmbSale.TabIndex = 0;
            this.cmbSale.SelectedIndexChanged += new System.EventHandler(this.cmbSale_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstProj);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.btnProj);
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Controls.Add(this.cmbSP);
            this.tabPage4.Controls.Add(this.cmbFP);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(339, 266);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Azuriraj projekciju";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstProj
            // 
            this.lstProj.FormattingEnabled = true;
            this.lstProj.Location = new System.Drawing.Point(5, 152);
            this.lstProj.Name = "lstProj";
            this.lstProj.Size = new System.Drawing.Size(305, 108);
            this.lstProj.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vreme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Izaberite salu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Izaberite film";
            // 
            // btnProj
            // 
            this.btnProj.Location = new System.Drawing.Point(235, 126);
            this.btnProj.Name = "btnProj";
            this.btnProj.Size = new System.Drawing.Size(75, 23);
            this.btnProj.TabIndex = 3;
            this.btnProj.Text = "OK";
            this.btnProj.UseVisualStyleBackColor = true;
            this.btnProj.Click += new System.EventHandler(this.btnProj_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // cmbSP
            // 
            this.cmbSP.FormattingEnabled = true;
            this.cmbSP.Location = new System.Drawing.Point(6, 86);
            this.cmbSP.Name = "cmbSP";
            this.cmbSP.Size = new System.Drawing.Size(201, 21);
            this.cmbSP.TabIndex = 1;
            // 
            // cmbFP
            // 
            this.cmbFP.FormattingEnabled = true;
            this.cmbFP.Location = new System.Drawing.Point(5, 46);
            this.cmbFP.Name = "cmbFP";
            this.cmbFP.Size = new System.Drawing.Size(201, 21);
            this.cmbFP.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 368);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Admin";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmDodaj;
        private System.Windows.Forms.Button btnFilmIzbrisi;
        private System.Windows.Forms.Button btnFilmDet;
        private System.Windows.Forms.ListBox lstBoxF;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSizbrisi;
        private System.Windows.Forms.Button btnSDodaj;
        private System.Windows.Forms.ListBox lstSale;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstKarte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.TextBox txtKarte;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.ComboBox cmbSale;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lstProj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbSP;
        private System.Windows.Forms.ComboBox cmbFP;
    }
}

