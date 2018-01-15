using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable()]
   public class Filmovi
    {
        private string naziv;
        private string opis;
        private string zanr;
        private double ocena;
        public int brOcena = 0;
        public int ukupnaOcena = 0;
        private int id;
        public static int brojac = 0;
        public bool ocenjen;

        public Filmovi()
        {
            id = ++brojac;
            ocena = 0;
            ocenjen = false;
            naziv = opis = zanr = "";
            
        }
        public Filmovi(string _naziv, string _opis , string _zanr)
        {
            id = ++brojac;
            naziv = _naziv;
            opis = _opis;
            zanr = _zanr;
            ocena = 0;
            ocenjen = false;

        }
        public string Naziv
        {
            get
            {
                return naziv;
            }
        }
        public string Opis
        {
            get
            {
                return opis;
            }
        }
        public string Zanr
        {
            get
            {
                return zanr;
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
        }
        public double Ocena
        {
            get
            {
                return ocena;
            }
        }
        public void setOcena(double x)
        {
            ocena = x;
        }
        public override string ToString()
        {
            return  "naziv:" + naziv;
        }
        public string IspisFilma()
        {
            return "Naziv filma:" + naziv + "Zanr filma:" + zanr + "Opis filma:" + opis + "Ocena filma:" + ocena;
        }
    }
}
