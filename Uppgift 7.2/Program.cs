using System.Collections.Generic;
using System.Globalization;

namespace Uppgift_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Största talet i listan är { Max()}");

            Console.ReadKey();
        }

        static int Max()
        {
            List<int> lista = new List<int>();
            int tal = 0;
            Console.WriteLine("Skriv in så många tal du vill och avsluta med en tom rad.");
            string svar = " ";
            while (svar != "")
            {
                Console.WriteLine("Skriv in ett tal:");
                svar = Console.ReadLine();

                if (svar != "")
                {
                    tal = int.Parse(svar);
                    lista.Add(tal);
                }
            }
            lista.Sort();

            return lista[lista.Count - 1 ];
        }
    }
}