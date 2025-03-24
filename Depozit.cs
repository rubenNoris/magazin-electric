using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin_electric
{
    class Depozit
    {
        private List<Produs> produse = new List<Produs>();

        public void AdaugaProdus(Produs produs)
        {
            produse.Add(produs);
        }

        public void VindeProdus(string nume, int cantitate)
        {
            Produs produs = produse.Find(p => p.Nume == nume);
            if (produs == null)
                throw new Exception("Produsul nu exista in depozit!");
            if (produs.Cantitate < cantitate)
                throw new Exception("Stoc insuficient!");

            produs.Cantitate -= cantitate;
            Factura.GenereazaFactura(produs.Nume, cantitate, produs.Pret * cantitate);
        }
    }
}
