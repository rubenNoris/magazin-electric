using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magazin_electric
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Depozit depozit = new Depozit();
            depozit.AdaugaProdus(new Produs("Frigider", 10, 1200));
            depozit.AdaugaProdus(new Produs("Masina de spalat", 5, 1500));

            Magazin magazin = new Magazin(depozit);
            magazin.Vinde("Frigider", 2);
            magazin.Vinde("Masina de spalat", 6); // va genera eroare
        }
    }
}
