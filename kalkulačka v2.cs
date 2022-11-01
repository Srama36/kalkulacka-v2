using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulačka
{
    class Program
    {
        static void Main(string[] args)
        {
            string odpoved = Console.ReadLine();
            int cislo1 = int.Parse(Console.ReadLine());
            string operace = Console.ReadLine();
            int cislo2 = int.Parse(Console.ReadLine());
            double vysledek = 0;
            


            while (odpoved == "ano")
            {
                if (operace == "+")
                {
                    vysledek = cislo1 + cislo2;
                }

                else if (operace == "-")
                {
                    vysledek = cislo1 - cislo2;
                }

                else if (operace == "*")
                {
                    vysledek = cislo1 * cislo2;
                }

                else if (operace == "/")
                {
                    vysledek = cislo1 / cislo2;
                }

                else if (operace == "%")
                {
                    vysledek = cislo1 % cislo2;
                }

                else
                {
                    Console.WriteLine("špatná operace");
                }

                Console.WriteLine(vysledek);
                Console.WriteLine("Chcete pokracovat? ano/ne");
                odpoved = Console.ReadLine();
                Console.ReadKey();
            } 
     
        }        
    }
}
