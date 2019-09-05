using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNr2
{
    class Programm
    {
        static void Main(string[] args)
        {
            // Beispielwerte
            double[] werte1 = new double[] { 2.5, 4.5 };
            double[] werte2 = new double[] { 1.2, 3.4, 5.6, 7.8, };
            double mittelwert = 0.0;

            /*
            double[] werte = new double[] { 3.5, 7.5 };
            double sum = 0;
            //Bilde die Summer über alle Elemente
            foreach (double item in werte2)
            {
                sum += item;
            }
            mittelwert=  sum / werte2.Length;
            */
            mittelwert = Average(werte1);
            Console.WriteLine(mittelwert);
            mittelwert = Average(werte2);
            Console.WriteLine(mittelwert);
            Console.ReadLine();
            
        }
        static double Average(double[] values)
        {
            double sum = 0;
            //Bilde die Summer über alle Elemente
            foreach (double item in values)
            {
                sum += item;
            }
            return sum / values.Length;
        }
    }
}
