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
    public partial class Ulaz : MetroFramework.Forms.MetroForm
    {
        public Ulaz()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.Equals(e.KeyChar, (char)Keys.Back) && !char.Equals(e.KeyChar, (char)Keys.Enter))
                e.Handled = true;

            if (e.KeyChar == ((char)Keys.Enter))
                button1_Click_1(this, new EventArgs());
        }

        


        private void button1_Click_1(object sender, EventArgs e)
        {
            String acc = textBox1.Text;
            if (acc == "Stefan")
            {
                Admin ad = new Admin();

                this.Hide();
                ad.ShowDialog();
                this.Show();
            }
            else if (acc.Trim().Length == 0)
            {
                MessageBox.Show("Unesite username.");
            }
            else
            {
                Prezentacija x = new Prezentacija(textBox1.Text);
                this.Hide();
                x.ShowDialog();
                this.Show();
               
                return;
            }
        }

       
    }
}
