using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_pary_liczb_naturalnych
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n = 0;

                Console.Write("Podaj liczbę n: ");
                n = int.Parse(Console.ReadLine());

                Console.Write("Wszystkie pary liczb naturalnych, których suma jest = " + n + " są następujące: ");
                for (int i = 0; i <= n; i++)
                {
                    Console.Write(" " + i + " i " + n + ", ");
                    n--;
                }

                Console.WriteLine("\n\nNaciśnij Escape aby zakończyć działanie programu albo dowolony klawisz aby kontynuować... \n");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
