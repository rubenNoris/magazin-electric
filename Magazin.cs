using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin_electric
{
    class Magazin
    {
        private Depozit depozit;

        public Magazin(Depozit depozit)
        {
            this.depozit = depozit;
        }

        public void Vinde(string nume, int cantitate)
        {
            try
            {
                depozit.VindeProdus(nume, cantitate);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare: " + ex.Message);
            }
        }
    }
}
