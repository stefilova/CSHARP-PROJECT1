using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace Projekat
{
       [Serializable()]
   public class user
    {
        public string username;
        public int brojKarata;
        public Filmovi mojiFilmovi;
        public List<Karte> mojeKarte;

        public user()
        {
            brojKarata = 0;
            username = "";
            mojiFilmovi = new Filmovi();
            mojeKarte = new List<Karte>();
        }

        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite("user.txt");
            bf.Serialize(fs, this);
            fs.Dispose();
            fs.Close();
        }
    }
}
