using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_konto_oszczednosciowe
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double k = 0, o = 0, m = 0;
                do
                {
                    Console.Write("Podaj kwotę początkową: ");
                    k = double.Parse(Console.ReadLine());
                } while (!(k > 0));

                do
                {
                    Console.Write("Podaj oprocentowanie konta w skali roku: ");
                    o = double.Parse(Console.ReadLine());
                } while (!(o > 0));

                do
                {
                    Console.Write("Podaj liczbę miesięcy: ");
                    m = double.Parse(Console.ReadLine());
                } while (!(m > 0 && m <= 12));

                double z = k * Math.Pow((1 + (o / 12 / 100)), m);
                double b = 0.19 * (z - k);
                z -= b;

                Console.WriteLine("Kwota zarobiona wynosi: " + (z-k) + "\n");

                Console.WriteLine("Naciśnij Escape jeśli chcesz zakończyć działanie programu albo dowolny klawicz jeśli chcesz kontynuować... \n");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
