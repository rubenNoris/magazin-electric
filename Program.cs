using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace magazin_electric
{
    class Program
    {
        static void Main(string[] args)
        {
            Depozit depozit = new Depozit();
            bool ruleaza = true;

            while (ruleaza)
            {
                Console.WriteLine("\n--- Meniu ---");
                Console.WriteLine("1. Adaugă produs");
                Console.WriteLine("2. Vinde produs");
                Console.WriteLine("3. Afișează stocul");
                Console.WriteLine("4. Ieșire");
                Console.Write("Alege o opțiune: ");

                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        Console.Write("Nume produs: ");
                        string nume = Console.ReadLine();
                        Console.Write("Cantitate: ");
                        int cantitate = int.Parse(Console.ReadLine());
                        Console.Write("Preț: ");
                        double pret = double.Parse(Console.ReadLine());
                        depozit.AdaugaProdus(new Produs(nume, cantitate, pret));
                        Console.WriteLine("Produs adăugat cu succes.");
                        break;

                    case "2":
                        Console.Write("Nume produs de vândut: ");
                        string numeVanzare = Console.ReadLine();
                        Console.Write("Cantitate: ");
                        int cantVanzare = int.Parse(Console.ReadLine());
                        try
                        {
                            depozit.VindeProdus(numeVanzare, cantVanzare);
                            Console.WriteLine("Produs vândut cu succes.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Eroare: " + ex.Message);
                        }
                        break;

                    case "3":
                        depozit.AfiseazaStoc();
                        break;

                    case "4":
                        ruleaza = false;
                        break;

                    default:
                        Console.WriteLine("Opțiune invalidă. Încearcă din nou.");
                        break;
                }
            }
            Console.WriteLine("Apasă Enter pentru a închide...");
            Console.ReadLine();
        }

    }
}
