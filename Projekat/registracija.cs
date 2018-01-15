using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Drawing;
using MetroFramework.Controls;
using System.Drawing;

namespace Projekat
{
    public partial class registracija : MetroFramework.Forms.MetroForm
    {
        public registracija()
        {
            InitializeComponent();
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.Equals(e.KeyChar, (char)Keys.Back) && !char.Equals(e.KeyChar, (char)Keys.Enter))
                e.Handled = true;

            if (e.KeyChar == ((char)Keys.Enter))
                button1_Click(this, new EventArgs());

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String acc = textBox1.Text + "" + textBox2.Text;
            String ime = textBox1.Text;
            String file;
            String[] niz;
            System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\Stefan\Desktop\files\TVP-PRVI PROJEKAT\acc.txt");
            while ((file = reader.ReadLine()) != null)
            {
                niz = file.Split(' ');
                if (String.Compare(niz[0], ime) == 0)
                {
                    MessageBox.Show("Username vec postoji, pokusajte ponovo");
                    reader.Close();
                    return;
                }
            }
            reader.Close();

            System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Users\Stefan\Desktop\files\TVP-PRVI PROJEKAT\acc.txt", true);
            writer.WriteLine(acc);
            writer.Close();
            MessageBox.Show("Nalog " + ime + " uspesno registrovan.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registracija_Load(object sender, EventArgs e)
        {
           
        }
    }
}
