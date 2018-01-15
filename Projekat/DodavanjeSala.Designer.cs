namespace Projekat
{
    partial class DodavanjeSala
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
            this.txtSalaDodaj = new System.Windows.Forms.TextBox();
            this.textRedoviS = new System.Windows.Forms.TextBox();
            this.textKoloneS = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnSalaDodaj = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtSalaDodaj
            // 
            this.txtSalaDodaj.Location = new System.Drawing.Point(131, 69);
            this.txtSalaDodaj.Name = "txtSalaDodaj";
            this.txtSalaDodaj.Size = new System.Drawing.Size(100, 20);
            this.txtSalaDodaj.TabIndex = 1;
            
            // 
            // textRedoviS
            // 
            this.textRedoviS.Location = new System.Drawing.Point(131, 95);
            this.textRedoviS.Name = "textRedoviS";
            this.textRedoviS.Size = new System.Drawing.Size(100, 20);
            this.textRedoviS.TabIndex = 3;
            // 
            // textKoloneS
            // 
            this.textKoloneS.Location = new System.Drawing.Point(131, 121);
            this.textKoloneS.Name = "textKoloneS";
            this.textKoloneS.Size = new System.Drawing.Size(100, 20);
            this.textKoloneS.TabIndex = 5;
            this.textKoloneS.TextChanged += new System.EventHandler(this.textKoloneS_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Naziv sale";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Redovi";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Kolone";
            // 
            // btnSalaDodaj
            // 
            this.btnSalaDodaj.Location = new System.Drawing.Point(131, 165);
            this.btnSalaDodaj.Name = "btnSalaDodaj";
            this.btnSalaDodaj.Size = new System.Drawing.Size(100, 59);
            this.btnSalaDodaj.TabIndex = 10;
            this.btnSalaDodaj.Text = "Dodaj salu";
            // 
            // DodavanjeSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 259);
            this.Controls.Add(this.btnSalaDodaj);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textKoloneS);
            this.Controls.Add(this.textRedoviS);
            this.Controls.Add(this.txtSalaDodaj);
            this.Name = "DodavanjeSala";
            this.Text = "DodavanjeSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSalaDodaj;
        private System.Windows.Forms.TextBox textRedoviS;
        private System.Windows.Forms.TextBox textKoloneS;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnSalaDodaj;
    }
}