using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable()]

    public class Projekcija
    {
        public int id;
        public static int brojac = 0;
        private Filmovi filmovi;
        private Sale sale;
        private DateTime vreme;
        public List<int> kupljeno;

        public Projekcija()
        {
            id = ++brojac;
            filmovi = new Filmovi();
            sale = new Sale();
            vreme = new DateTime();
            kupljeno = new List<int>();
        }

        public Projekcija(Filmovi _filmovi, Sale _sale, DateTime _vreme)
        {
            id = ++brojac;
            filmovi = _filmovi;
            sale = _sale;
            vreme = _vreme;
            kupljeno = new List<int>();
        }

        public int ID
        {
            get
            {
                return id;
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
        public DateTime getVreme
        {
            get
            {
                return vreme;
            }
        }

        public override string ToString()
        {
            return "Naziv filma:" + filmovi.Naziv + "Naziv sale:" + sale.Naziv + "Vreme:" + vreme.Day + "." + vreme.Month + "." + vreme.Year + ". / " + vreme.Hour + ":" + vreme.Minute;
        }
    }
}
