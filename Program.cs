using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_to_2_szamrendszer_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ih=true ;
            do
            {
                Console.Write("Kérek egy számot: ");
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Milyen számrendszerbe váltsam? ");
                int szamrendszer = Convert.ToInt32(Console.ReadLine());
                
                
                
                     
                if (szamrendszer<=16 && szamrendszer>1)
                {
                    int maradek;
                    int megadott_szam = szam;
                    string e = "";
                    Console.WriteLine("{0}\t | \t {1}", megadott_szam, szamrendszer);
                    Console.WriteLine("--------------------------------------------");
                    while (szam > 0)
                    {
                        string m = "";
                        maradek = szam % szamrendszer;
                        szam = szam / szamrendszer;
                        Console.WriteLine("{0} \t | \t {1}", szam, maradek);
                        switch (maradek)
                        {
                            case 10: m = "A"; break;
                            case 11: m = "B"; break;
                            case 12: m = "C"; break;
                            case 13: m = "D"; break;
                            case 14: m = "E"; break;
                            case 15: m = "F"; break;
                            default: m = Convert.ToString(maradek); break;
                        }

                        e = e + m;
                    }

                    Console.WriteLine("A {0} szám  a {1}-es számrendszer beli értéke: ", megadott_szam, szamrendszer);

                    for (int i = e.Length - 1; i >= 0; i--)
                    {
                        Console.Write("{0}", e[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Nincs ilyen számrendszer.");
                }
                Console.WriteLine("Nyomj egy x-et a  kilépéshez vagy Entert az újrakézdéshez.");

                string c = Console.ReadLine();
                if (c == "x")
                {
                    ih = false;
                }
                Console.Clear();
            } while (ih);
            
        }
    }
}
