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
    
    public partial class Prezentacija : MetroFramework.Forms.MetroForm
    {
        Administrator administrator;
        user user;
        public Prezentacija(String username)
        {
            InitializeComponent();
            administrator = new Administrator();
            user = new user();
            label3.Text = username;
            user.username = username;

            if(File.Exists("administrator.txt"))
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

        private void Prezentacija_Load(object sender, EventArgs e)
        {
           
            for( int i = 0; i< administrator.listaFilmova.Count; i++)
            {
                listBox1.Items.Add(administrator.listaFilmova[i]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(((Filmovi)(listBox1.SelectedItem)).IspisFilma());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for(int i =0; i<administrator.listaProjekcija.Count; i++)
            {
                if(administrator.listaProjekcija[i].getFilmovi == ((Filmovi)(listBox1.SelectedItem)))
                    {
                    listBox2.Items.Add(administrator.listaProjekcija[i]);
                    }
            }
        }

      

        private void button2_Click_1(object sender, EventArgs e)
        {
            KupovinaKarata k = new KupovinaKarata(administrator, listBox2.SelectedItem as Projekcija, user);
            k.ShowDialog();
           
        }

        private void Prezentacija_FormClosing(object sender, FormClosingEventArgs e)
        {
            user.Save();
            administrator.Save();
        }
    }
}
