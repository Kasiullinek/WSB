using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_zgadywanie_liczb
{
    class Program
    {
        static void Main(string[] args)
        {
            int odp = 0, n = 1, min = 1, max = 20;
            Random random = new Random();
            int los = random.Next(min, max+1);

            Console.WriteLine("Proponowana liczba z przedziału od 1 do 20 = " + los);

            do
            {
                Console.WriteLine("\nNapisz:");
                Console.WriteLine("I. liczbę ujemną, jeśli propozycja jest mniejsza od szukanej liczby, ");
                Console.WriteLine("II. liczbę dodatnią, jeśli propozycja jest większa od szukanej liczby, ");
                Console.WriteLine("III. zero, jeśli propozycja jest szukaną liczbą. ");
                odp = int.Parse(Console.ReadLine());

                if (odp == 0)
                {
                    Console.WriteLine("Zgadłem w " + n + " próbach");
                }
                else
                {
                    if (odp < 0)
                    {
                        max = max;
                        min = los;
                        int nowyLos = random.Next(min, max + 1);
                        Console.WriteLine("Nowy los z przedziału od " + min + " do " + max + " = " + nowyLos);
                        los = nowyLos;

                    }
                    else
                    {
                        min = min;
                        max = los;
                        int nowyLos = random.Next(min, max + 1);
                        Console.WriteLine("Nowy los z przedziału od " + min + " do " + max + " = " + nowyLos);
                        los = nowyLos;
                    }

                    n++;
                }
            } while (odp != 0);

            Console.ReadKey();
        }
    }
}
