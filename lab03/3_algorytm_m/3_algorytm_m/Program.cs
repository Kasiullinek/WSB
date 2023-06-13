using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_algorytm_m
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double n = 0, k = 0, m = 0;
                do
                {
                    Console.Write("Podaj n, gdzie n to liczba naturalna nie mniejsza od 5: ");
                    n = double.Parse(Console.ReadLine());
                } while (n < 5);

                do
                {
                    Console.Write("Podaj k, gdzie k to liczba naturalna nie mniejsza od 5: ");
                    k = double.Parse(Console.ReadLine());
                } while (k < 5);

                n = ObliczSilnie(n);
                k = ObliczSilnie(k);

                m = (n - k) / k;

                Console.WriteLine();
                Console.WriteLine("m = (n!-k!)/k! = " + m + "\n");

                Console.WriteLine("Naciśniej Escape aby zakończyć działanie programu albo dowlony klawisz aby kontynuować... \n");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static double ObliczSilnie(double x)
        {
            double wynik = x;

            if (x > 1)
            {
                wynik = x * ObliczSilnie(x - 1);
            }

            return wynik;
        }
    }
}
