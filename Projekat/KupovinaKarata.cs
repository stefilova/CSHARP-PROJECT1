using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class KupovinaKarata : MetroFramework.Forms.MetroForm
    {
        Administrator administrator;
        Projekcija projekcija;
        Button[] nizSedista;
        List<int> nizCena;
        int zauzeto = 0;
        int brojac;
        user user;
        
        public KupovinaKarata(Administrator a, Projekcija p, user u)
        {
            InitializeComponent();
            nizCena = new List<int>();
            administrator = a;
            projekcija = p;
            brojac = 0;
            user = u;


            for(int i= 0; i<administrator.listaKarata.Count; i++)
            {
                if (!nizCena.Contains(administrator.listaKarata[i].Cena) && projekcija.getSale == administrator.listaKarata[i].getSale)
                    nizCena.Add(administrator.listaKarata[i].Cena);
            }

            nizSedista = new Button[p.getSale.BrMesta];
            for(int i=0; i<projekcija.getSale.BrMesta; i++)
            {
                Button btn = new Button() { Text= "" + i };
                btn.Click += Btn_Click;
                nizSedista[i] = btn;
            }

            
        }
        private void Btn_check()
        {
            if (brojac == 0 || comboBox1.SelectedItem == null)
                button3.Enabled = false;
            else
                button3.Enabled = true;

            if (user.mojeKarte.Count == 0 || textBox1.Text.Length == 0 || user.mojiFilmovi.ocenjen == true || int.Parse(textBox1.Text) == 0)
                  button2.Enabled = false;
            else
                   button2.Enabled = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if(brojac>5 && b.BackColor != Color.Red)
            {
                MessageBox.Show("Ne mozete kupiti vise od 6 karata!");
                Btn_check();
                return;
            }
            if(b.BackColor == Color.Red)
            {
                brojac--;
                b.BackColor = DefaultBackColor;
                Btn_check();
            }
            else
            {
                b.BackColor = Color.Red;
                brojac++;
                Btn_check();
            }


        }

        private void KupovinaKarata_Load(object sender, EventArgs e)
        {
            for( int i =0; i< nizCena.Count; i++)
            {
                comboBox1.Items.Add(nizCena[i]);
            }
            tableLayoutPanel1.ColumnCount = projekcija.getSale.brKol;
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 0; i < projekcija.getSale.brKol; i++)
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / projekcija.getSale.BrKol));


            tableLayoutPanel1.RowCount = projekcija.getSale.brRed;
            tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < projekcija.getSale.brRed; i++)
                tableLayoutPanel1.RowStyles.Add(new ColumnStyle(SizeType.Percent, 100F / projekcija.getSale.BrRed));


            tableLayoutPanel1.Controls.AddRange(nizSedista);
            for(int i =0; i<projekcija.getSale.brRed; i++)
                for(int j=0; j<projekcija.getSale.brKol; j++)
                    for(int k=0; k<projekcija.kupljeno.Count; k++)
                        if(tableLayoutPanel1.GetControlFromPosition(j,i).Text == projekcija.kupljeno[k].ToString())
                        {
                            tableLayoutPanel1.GetControlFromPosition(j, i).Enabled = false;
                        }
            nadji();
            Btn_check();
          

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int[] zauzeta = new int[6];
            int s = 0;
            user.mojiFilmovi = new Filmovi();
                for(int i =0; i<projekcija.getSale.BrRed; i++)
                    for(int j=0; j<projekcija.getSale.BrKol; j++)
                { if (tableLayoutPanel1.GetControlFromPosition(j, i).BackColor == Color.Red)
                    {
                        zauzeta[s] = int.Parse(((Button)tableLayoutPanel1.GetControlFromPosition(j, i)).Text);
                        s++;
                        tableLayoutPanel1.GetControlFromPosition(j, i).Enabled = false;
                    }

                }
                for(int i = 0; i<administrator.listaKarata.Count; i++)
                {
                    if(administrator.listaKarata[i].Cena == (int)comboBox1.SelectedItem && zauzeta.Contains(administrator.listaKarata[i].mesto))
                     {
                             user.mojeKarte.Add(administrator.listaKarata[i]);
                }    

                }
                foreach(int x in zauzeta)
          
                projekcija.kupljeno.Add(x);
                Btn_check();
                nadji();
                Invalidate();
            
                        


        }

        private void KupovinaKarata_Paint(object sender, PaintEventArgs e)
        {
            int visina = 1;
            Graphics sb = e.Graphics;
            Pen green = new Pen(Color.LawnGreen, 10);
           
            Rectangle getrect = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width * zauzeto / projekcija.getSale.BrMesta, panel1.Height * visina);
            sb.DrawRectangle(green, getrect);
            
          






        }
        private void nadji()
        {
            zauzeto = 0;
                for(int i =0; i<projekcija.getSale.brRed; i++)
                    for(int j=0; j<projekcija.getSale.brKol; j++)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(j, i).Enabled == false) zauzeto++;
                }
            label3.Text = " Popunjeno je" + zauzeto * 1.0 / projekcija.getSale.BrMesta * 100.0 + "% sale"; 
        }

        private void KupovinaKarata_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void KupovinaKarata_FormClosed(object sender, FormClosedEventArgs e)
        {
            //user.Save();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Btn_check();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text != "")
                e.Handled = true;
            else if (!char.IsDigit(e.KeyChar) && !char.Equals(e.KeyChar, (char)Keys.Back))
                e.Handled = true;
            else
            {
                if (e.KeyChar > '5')
                {
                    textBox1.Text = "5";
                    e.Handled = true;
                }
                else if(e.KeyChar < '0')
                {
                    textBox1.Text = "0";
                    e.Handled = true;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            projekcija.getFilmovi.brOcena++;
            projekcija.getFilmovi.ukupnaOcena = projekcija.getFilmovi.ukupnaOcena + int.Parse(textBox1.Text);
            projekcija.getFilmovi.setOcena((double)projekcija.getFilmovi.ukupnaOcena / (double)projekcija.getFilmovi.brOcena * 1.0);
            user.mojiFilmovi.ocenjen = true;
            Btn_check();
            MessageBox.Show("Uspesno ste ocenili"+ " " + projekcija.getFilmovi.Naziv+ " " +  "film!");
        }
    }
}
