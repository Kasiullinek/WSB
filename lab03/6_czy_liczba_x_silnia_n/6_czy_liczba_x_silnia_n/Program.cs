using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_czy_liczba_x_silnia_n
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double n = 0, x = 0;

                Console.Write("Podaj liczbę n: ");
                n = double.Parse(Console.ReadLine());
                Console.Write("Podaj liczbę x: ");
                x = double.Parse(Console.ReadLine());

                double nS = Silnia(n);

                if (x == nS)
                {
                    Console.WriteLine("Wprowadzona liczba x jest silnią liczby n = " + n);
                }
                else
                {
                    Console.WriteLine("Wprowadzona liczba x nie jest silnią liczby n");
                }

                Console.WriteLine("\nNaciśniej Escape aby zakończyć działanie programu albo dowlony klawisz aby kontynuować... \n");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }
        static double Silnia(double s)
        {
            double wynik = s;

            if (s > 1)
            {
                wynik = s * Silnia(s - 1);
            }
            else
            {
                wynik = 1;
            }

            return wynik;
        }
    }
}
