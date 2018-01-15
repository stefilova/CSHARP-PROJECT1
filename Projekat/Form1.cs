using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Projekat
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        Administrator administrator;
        public Admin()
        {
            InitializeComponent();
            administrator = new Administrator();
            if (File.Exists("administrator.txt"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead("administrator.txt");


                administrator = bf.Deserialize(fs) as Administrator;
                if (administrator.listaFilmova.Count != 0)
                    Filmovi.brojac = administrator.listaFilmova.ElementAt(administrator.listaFilmova.Count - 1).ID;
                if (administrator.listaKarata.Count != 0)
                    Karte.brojac = administrator.listaKarata.ElementAt(administrator.listaKarata.Count - 1).ID;
                if (administrator.listaSala.Count != 0)
                    Sale.brojac = administrator.listaSala.ElementAt(administrator.listaSala.Count - 1).ID;
                if (administrator.listaProjekcija.Count != 0)
                    Projekcija.brojac = administrator.listaProjekcija.ElementAt(administrator.listaProjekcija.Count - 1).ID;
                fs.Dispose();
                fs.Close();

            }
        }

        public void ListaProvera()
        {
            if (lstBoxF.SelectedItems.Count == 0)
            {
                btnFilmIzbrisi.Enabled = false;
                btnFilmDet.Enabled = false;
            }
            else
            {
                btnFilmIzbrisi.Enabled = true;
                btnFilmDet.Enabled = true;

            }
            if (lstSale.SelectedItems.Count == 0)
                btnSizbrisi.Enabled = false;
            else
                btnSizbrisi.Enabled = true;
            if (cmbFilm.SelectedItem == null || cmbSale.SelectedItem == null || txtKarte.Text.Trim().Length == 0)
            {
                btnKarte.Enabled = false;
            }
            else
                btnKarte.Enabled = true;
           // if (cmbFP.SelectedItem == null || cmbSP.SelectedItem == null)
           //     btnProj.Enabled = false;
          //  else
          //      btnProj.Enabled = true;
        }

        private void btnFilmIzbrisi_Click(object sender, EventArgs e)
        {
            for(int i = administrator.listaProjekcija.Count-1; i>=0; i--)
                if(administrator.listaProjekcija[i].getFilmovi == (Filmovi)lstBoxF.SelectedItem)
                {
                    administrator.listaProjekcija.RemoveAt(i);
                    lstProj.Items.RemoveAt(i);
                }
            for(int i = administrator.listaKarata.Count-1; i>=0; i--)
                if(administrator.listaKarata[i].getFilmovi== (Filmovi)lstBoxF.SelectedItem)
                {
                    administrator.listaKarata.RemoveAt(i);
                    lstKarte.Items.RemoveAt(i);
                }
            administrator.listaFilmova.Remove((Filmovi)lstBoxF.SelectedItem);
            cmbFilm.Items.Remove(lstBoxF.SelectedItem);
            cmbFP.Items.Remove(lstBoxF.SelectedItem);
            lstBoxF.Items.Remove(lstBoxF.SelectedItem);
            ListaProvera();
        }

        private void btnFilmDet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Filmovi)lstBoxF.SelectedItem).IspisFilma());
            ListaProvera();
        }

       //public void Ucitavanje()
       // {
       //     for( int i = 0; i<administrator.listaFilmova.Count; i++)
       //     {
       //         lstBoxF.Items.Add(administrator.listaFilmova[i]);
       //         cmbFilm.Items.Add(administrator.listaFilmova[i]);
       //         cmbFP.Items.Add(administrator.listaFilmova[i]);
       //     }
       //     for( int i = 0; i<administrator.listaSala.Count; i++)
       //     {
       //         lstSale.Items.Add(administrator.listaSala[i]);
       //         cmbSale.Items.Add(administrator.listaSala[i]);
       //         cmbSP.Items.Add(administrator.listaSala[i]);
       //     }
       //     for(int i = 0; i<administrator.listaKarata.Count; i++)
       //     {
       //         lstKarte.Items.Add(administrator.listaKarata[i]);
       //     }
       //     for(int i = 0; i<administrator.listaProjekcija.Count; i++)
       //     {
       //         lstProj.Items.Add(administrator.listaProjekcija[i]);
       //     }
       //     ListaProvera();
       // }

        private void btnFilmDodaj_Click(object sender, EventArgs e)
        {
            DodavanjeFilma forma = new DodavanjeFilma();
            if(forma.ShowDialog(this) == DialogResult.OK)
            {
                administrator.listaFilmova.Add(forma.DodajFilm());
                lstBoxF.Items.Add(administrator.listaFilmova[administrator.listaFilmova.Count - 1]);
                cmbFilm.Items.Add(administrator.listaFilmova[administrator.listaFilmova.Count - 1]);
                cmbFP.Items.Add(administrator.listaFilmova[administrator.listaFilmova.Count - 1]);
                ListaProvera();
            }
        }

        private void lstBoxF_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaProvera();
        }

        private void btnSDodaj_Click(object sender, EventArgs e)
        {
            DodavanjeSala DodavanjeSale = new DodavanjeSala();
            if(DodavanjeSale.ShowDialog(this) == DialogResult.OK)
            {
                administrator.listaSala.Add(DodavanjeSale.DodajSalu());
                cmbSale.Items.Add(administrator.listaSala[administrator.listaSala.Count - 1]);
                cmbSP.Items.Add(administrator.listaSala[administrator.listaSala.Count - 1]);
                lstSale.Items.Add(administrator.listaSala[administrator.listaSala.Count - 1]);
                
            }
        }

        private void btnSizbrisi_Click(object sender, EventArgs e)
        {
            for(int i= administrator.listaProjekcija.Count - 1; i>=0; i--)
                if(administrator.listaProjekcija[i].getSale == (Sale)lstSale.SelectedItem)
                {
                    administrator.listaProjekcija.RemoveAt(i);
                    lstProj.Items.RemoveAt(i);
                }
            for(int i=administrator.listaKarata.Count - 1; i>= 0; i--)
                if(administrator.listaKarata[i].getSale == (Sale)lstSale.SelectedItem)
                {
                    administrator.listaKarata.RemoveAt(i);
                    lstKarte.Items.RemoveAt(i);
                }
            administrator.listaSala.Remove((Sale)lstSale.SelectedItem);
            cmbSale.Items.Remove(lstSale.SelectedItem);
            cmbSP.Items.Remove(lstSale.SelectedItem);
            lstSale.Items.Remove(lstSale.SelectedItem);
            
        }

        private void btnKarte_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < ((Sale)cmbSale.SelectedItem).BrMesta; i++)
            {
                Karte tiket = new Karte(((Filmovi)cmbFilm.SelectedItem), ((Sale)cmbSale.SelectedItem), i, int.Parse(txtKarte.Text));
                administrator.listaKarata.Add(tiket);
                lstKarte.Items.Add(administrator.listaKarata[administrator.listaKarata.Count - 1]);

            }
            MessageBox.Show("Uspesno ste napravili kartu!");
            ListaProvera();
        }

        private void txtKarte_TextChanged(object sender, EventArgs e)
        {
            ListaProvera();
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaProvera();
        }

        private void cmbSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaProvera();
        }

        private void lstSale_SelectedIndexChanged(object sender, EventArgs e)
        {
           ListaProvera();
        }

        private void btnProj_Click(object sender, EventArgs e)
        {
            Projekcija termin = new Projekcija(((Filmovi)cmbFilm.SelectedItem), ((Sale)cmbSale.SelectedItem), dateTimePicker1.Value);
            administrator.listaProjekcija.Add(termin);
            lstProj.Items.Add(administrator.listaProjekcija[administrator.listaProjekcija.Count -1]);
            ListaProvera();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            administrator.Save();
            //Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < administrator.listaFilmova.Count; i++)
            {
                lstBoxF.Items.Add(administrator.listaFilmova[i]);
                cmbFilm.Items.Add(administrator.listaFilmova[i]);
                cmbFP.Items.Add(administrator.listaFilmova[i]);
            }
            for (int i = 0; i < administrator.listaSala.Count; i++)
            {
                lstSale.Items.Add(administrator.listaSala[i]);
                cmbSale.Items.Add(administrator.listaSala[i]);
                cmbSP.Items.Add(administrator.listaSala[i]);
            }
            for (int i = 0; i < administrator.listaKarata.Count; i++)
            {
                lstKarte.Items.Add(administrator.listaKarata[i]);
            }
            for (int i = 0; i < administrator.listaProjekcija.Count; i++)
            {
                lstProj.Items.Add(administrator.listaProjekcija[i]);
            }
            ListaProvera();
        }
    }
}
