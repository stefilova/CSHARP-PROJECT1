using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable()]
    public class Sale
    {
        private int brMesta;
        private int id;
        private string naziv;
        public static int brojac = 0;
        public int brRed;
        public int brKol;

        public Sale()
        {
            id = ++brojac;
            naziv = "";
            brMesta = brRed = brKol = 0;    
        }
        public Sale(string _naziv, int red, int kol)
        {
            id = ++brojac;
            naziv = _naziv;
            brRed = red;
            brKol = kol;
            brMesta = red * kol;
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
        }
        public int BrMesta
        {
            get
            {
                return brMesta;
            }
        }
        public int BrRed
        {
            get
            {
                return brRed;
            }
        }
        public int BrKol
        {
            get
            {
                return brKol;
            }
        }
        public override string ToString()
        {
            return "Naziv:" + naziv + "Br Mesta:" + brMesta;
        }
    }

}
