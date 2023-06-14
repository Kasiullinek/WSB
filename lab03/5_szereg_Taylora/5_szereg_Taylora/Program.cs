using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_szereg_Taylora
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n = 0;

                Console.WriteLine("Algorytm szacujący wartość funkcji e^x.");
                do
                {
                    Console.Write("Podaj liczbę n, która jest liczbą pierwszych wyrazów, które należy zsumować: ");
                    n = int.Parse(Console.ReadLine());
                } while (n <= 0);

                double e = 0;

                for (int i = 0; i <= n; i++)
                {
                   int silnia = Silnia(i);
                   e += Math.Pow(1, i) / silnia;
                }

                Console.WriteLine("\ne^1 pierwszych " + n + " wyrazów wynosi: " + e + "\n");
                Console.WriteLine("Naciśniej Escape aby zakończyć działanie programu albo dowlony klawisz aby kontynuować... \n");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }

        static int Silnia(int s)
        {
            int wynik = s;

            if (s > 1)
            {
                wynik = s * Silnia(s - 1);
            }else
            {
                wynik = 1;
            }

            return wynik;
        }
    }
}
