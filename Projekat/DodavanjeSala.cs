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
    public partial class DodavanjeSala : MetroFramework.Forms.MetroForm
    {
        public DodavanjeSala()
        {
            InitializeComponent();
            btnSalaDodaj.DialogResult = DialogResult.OK;

        }
        private void DodavanjeSala_load( object sender, EventArgs e)
        {
            if (txtSalaDodaj.Text.Trim().Length == 0 || textRedoviS.Text.Trim().Length == 0 || textKoloneS.Text.Trim().Length == 0)
                btnSalaDodaj.Enabled = false;
            else btnSalaDodaj.Enabled = true;
        }
        public Sale DodajSalu()
        {
            if (txtSalaDodaj.Text.Trim().Length != 0 && textRedoviS.Text.Trim().Length != 0 && textKoloneS.Text.Trim().Length != 0)
            {
                Sale nova = new Sale(txtSalaDodaj.Text, int.Parse(textRedoviS.Text), int.Parse(textKoloneS.Text));
                return nova;
                this.Close();
            }
            else
                return null;
        }

        
        private void textKoloneS_TextChanged(object sender, EventArgs e)
        {
            if (txtSalaDodaj.Text.Trim().Length == 0 || textRedoviS.Text.Trim().Length == 0 || textKoloneS.Text.Trim().Length == 0 || int.Parse(textRedoviS.Text) == 0 || int.Parse(textKoloneS.Text) == 0)
                btnSalaDodaj.Enabled = false;
            else btnSalaDodaj.Enabled = true;
        }
    }
}
