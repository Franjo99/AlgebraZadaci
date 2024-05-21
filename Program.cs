using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AlgebraZadaci
{
    /// <summary>
    /// Zadaci za vježbanje - Tura 3 i Tura 5
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            PokreniMetode();
            Console.ReadKey();
        }

        static void PokreniMetode()
        {
            UsporediZivotinje();
            NacrtajPiramidu();
            SortirajNiz();
            NeparniBrojevi();
            DjeljiviBrojevi();
            PalendromeCheck();
        }

        //Tura 3.1 - Petlja koja uspoređuje nizove životnja
        static void UsporediZivotinje()
        {
            string[] zivotinje1 = { "pas", "konj", "jazavac", "zebra", "mrav", "jelen", "klokan" };
            string[] zivotinje2 = { "mrav", "žirafa", "konj", "pas", "dikobraz", "lav", "mačka", "kokoš" };
            List<string> zajednickeZivotinje = new List<string>();
            Console.WriteLine("Usporedba 2 niza \n");

            foreach (string zivotinja in zivotinje1)
            {
                if (zivotinje2.Contains(zivotinja))
                {
                    Console.WriteLine("{0} se nalazi u oba niza", zivotinja);
                    zajednickeZivotinje.Add(zivotinja);
                }
                else if(!zivotinje2.Contains(zivotinja))
                {
                    Console.WriteLine("{0} se nalazi u prvom nizu, ali se ne nalazi u drugom nizu", zivotinja);
                }
            }
            Console.WriteLine("U oba niza nalaze se " + string.Join(", ", zajednickeZivotinje.OrderByDescending(zajednickeZivotinje.IndexOf)));
            Console.WriteLine("\n\n");

        }

        //Tura 3.2 - Prikažite obrazac poput piramide s brojevima uvećanima za 1
        static void NacrtajPiramidu()
        {
            int i;
            int j;
            int x;
            int y = 1;
            int razmak;
            int brojRedova = 10; 


            Console.Write("Piramida s brojevima uvečanima za 1\n");  

            razmak = brojRedova + 1;

            for (i = 1; i <= brojRedova; i++) 
            {
                for (x = razmak; x >= 1; x --)
                {
                    Console.Write(" ");  
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", y++);
                }
                Console.Write("\n");
                razmak--;
            }
            Console.WriteLine("\n\n");
        }

        //Tura 3.3 - Poredaj unešeni niz u rastučem redoslijedu
        static void SortirajNiz()
        {
            // primjer s unešenim nizom
            int[] nesortiraniNiz = { 111, 2, 13, 45, 154325, 1, 12, 2432 };

            Console.WriteLine("Nesortirani niz je: " + string.Join(", ", nesortiraniNiz));
            Array.Sort(nesortiraniNiz);
            Console.WriteLine("Sortirani niz je: " + string.Join(", ", nesortiraniNiz) + "\n\n");

            //primjer s ArrayListom
            ArrayList niz = new ArrayList();
            var broj = UnesiBroj();

            while (broj != "kraj")
            {
                if(int.TryParse(broj, out int brojParsed))
                {
                    niz.Add(brojParsed);
                }
                else
                {
                    Console.WriteLine("Neispravan unos");
                }
                broj = UnesiBroj();
            }

            niz.Sort();
            var sortiraniNiz = niz.ToArray();
            Console.WriteLine("Sortirani niz je: " + string.Join(", ", sortiraniNiz) + "\n\n");
        }

        static string UnesiBroj() 
        {
            Console.Write("Unesi neki broj: ");
            return Console.ReadLine(); 
        }

        //Tura 3.4 - Ispis neparnih brojeva koji su veći od 1, a manji od 20
        static void NeparniBrojevi()
        {
            Console.WriteLine("Neparni brojevi koji su veći od 1, a manji od 20 \n");
            for (int i = 1; i < 20; i += 2)
            {
                if (i == 1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("{0}", i.ToString());
                }

            }

            Console.WriteLine("\n");

            Console.WriteLine("Neparni brojevi koji su veći od 1, a manji od 20 \n");
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 != 0 && i > 1)
                {
                    Console.WriteLine("{0}", i.ToString());
                }
                else
                {
                    continue;
                }

            }

            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.WriteLine("{0}", y.ToString());
                }
            }
        }

        //Tura 3.5 - Ispis brojeva iz intervala [1,300] koji su djeljivi s 5
        static void DjeljiviBrojevi()
        {
            Console.WriteLine("Brojevi iz intervala [1,300] koji su djeljivi s 5 \n");

            for (int i = 1; i <= 300; i++)
            {
                if(i % 5 == 0)
                {
                    Console.WriteLine("{0}", i.ToString()); ;
                }
                else
                {
                    continue;
                }
            }

        }

        //Tura 5.2 - Primjer metode koja provjerava da li je neka riječ palindrom (isto se piše odostraga)
        static void PalendromeCheck()
        {
            string palindrom = "";
            Console.Write("Upišite riječ da proverimo ako je palindrom: ");
            palindrom = Console.ReadLine();
            Console.WriteLine(IsPalenDrome(palindrom).ToString());
        }

        static bool IsPalenDrome(string text)
        {
            var reverseText = string.Join("", text.ToLower().Reverse());
            return reverseText == text;
        }
    }

}
