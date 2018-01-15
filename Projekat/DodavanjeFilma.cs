using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class DodavanjeFilma : MetroFramework.Forms.MetroForm
    {
        public DodavanjeFilma()
        {
            InitializeComponent();
            btnDodajFilm.DialogResult = DialogResult.OK;
        }

        private void DodavanjeFilma_Load(object sender, EventArgs e)
        {
            if (txtNazivFilm.Text.Trim().Length == 0 || txtZanr.Text.Trim().Length == 0 || txtOpis.Text.Trim().Length == 0)

                btnDodajFilm.Enabled = false;

            else btnDodajFilm.Enabled = true;
             
        }

        public Filmovi DodajFilm()
        {
            if (txtNazivFilm.Text.Trim().Length != 0 && txtZanr.Text.Trim().Length != 0 && txtOpis.Text.Trim().Length != 0)
            {
                Filmovi novi = new Filmovi(txtNazivFilm.Text, txtZanr.Text, txtOpis.Text);
                return novi;
                this.Close();
            }
            else
                return null;
        }

       

        private void txtZanr_TextChanged(object sender, EventArgs e)
        {
            if (txtNazivFilm.Text.Trim().Length == 0 || txtZanr.Text.Trim().Length == 0 || txtOpis.Text.Trim().Length == 0)
                btnDodajFilm.Enabled = false;
            else btnDodajFilm.Enabled = true;
        }
    }
}
