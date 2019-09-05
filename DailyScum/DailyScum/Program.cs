using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyScum
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 0;
            int x = 0;
            while (x <= 10)
            {
                x++;
                try
                {
                    Console.Write("Bitte eine ganze Zahl eingeben:");
                    string eingabe = Console.ReadLine();
                    zahl = Convert.ToInt32(eingabe);
                    x = 20;
                }
                catch (Exception Miau)
                {
                    Console.WriteLine(Miau.Message);
                }
            }

            if (x == 20)
            {
                Console.Write("Ihre angegebene ganze Zahl ist:");
                Console.WriteLine(zahl);
            }
            else
            {
                Console.WriteLine("Sie haben zu viele Anläufe gebraucht.");
            }
            Console.ReadLine();
        }
    }
}