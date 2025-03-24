using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin_electric
{
    class Factura
    {
        public static void GenereazaFactura(string numeProdus, int cantitate, double total)
        {
            string factura = $"Produs: {numeProdus}, Cantitate: {cantitate}, Total: {total:C}";
            Console.WriteLine(factura);
            //File.AppendAllText("facturi.txt", factura + "\n");
        }
    }
}
