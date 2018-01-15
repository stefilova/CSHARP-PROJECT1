using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable()]
   public class Karte
    {
        public int id;
        public static int brojac = 0;
        public int cena;
        public int mesto;
        private Filmovi filmovi;
        private Sale sale;

        public Karte()
        {
            id = ++brojac;
            filmovi = new Filmovi();
            sale = new Sale();
            mesto = 0;
            cena = 0;
        }

        public Karte(Filmovi _filmovi, Sale _sale, int _mesto, int _cena)
        {
            id = ++brojac;
            filmovi = _filmovi;
            sale = _sale;
            mesto = _mesto;
            cena = _cena;
        }
        public int ID
        {
            get
            {
                return id;
            }
        }
        public int Cena
        {
            get
            {
                return cena;
            }
        }
        public int Mesto
        {
            get
            {
                return mesto;
            }
        }
        public Filmovi getFilmovi
        {
            get
            {
                return filmovi;
            }
        }
        public Sale getSale
        {
            get
            {
                return sale;
            }
        }
        public override string ToString()
        {
            return "Sediste:" + mesto + "Naziv filma:" + filmovi.Naziv + "Sala:" + sale.Naziv;
        }
    }
}
