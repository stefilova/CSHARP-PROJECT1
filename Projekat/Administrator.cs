using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Projekat
{
    [Serializable()]
  public class Administrator
    {

        public List<Sale> listaSala;
        public List<Filmovi> listaFilmova;
        public List<Karte> listaKarata;
        public List<Projekcija> listaProjekcija;

        public Administrator()
        {
            listaFilmova = new List<Filmovi>();
            listaSala = new List<Sale>();
            listaKarata = new List<Karte>();
            listaProjekcija = new List<Projekcija>();
        }

        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite("administrator.txt");
            bf.Serialize(fs, this);
            fs.Dispose();
            fs.Close();
        }
    }
}
