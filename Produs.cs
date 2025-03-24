using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin_electric
{
    class Produs
    {
        public string Nume { get; set; }
        public int Cantitate { get; set; }
        public double Pret { get; set; }

        public Produs(string nume, int cantitate, double pret)
        {
            Nume = nume;
            Cantitate = cantitate;
            Pret = pret;
        }
    }
}
