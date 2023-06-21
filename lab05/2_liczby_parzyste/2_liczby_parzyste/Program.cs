using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_liczby_parzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Ile liczb parzystych wypisać?");
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n > 0));

            Console.Write("\nLiczby parzyste: ");

            //ZnajdzLiczbeParzystaA(n);
            ZnajdzLiczbeParzystaB(n);

            Console.Read();
        }
        
        static void ZnajdzLiczbeParzystaA(int n)
        {
            Random random = new Random();

            int licznik = 0, liczba = 0;

            for(int i = 0; i < n; i++)
            {
                do
                {
                    liczba = random.Next(-8, 9);
                    licznik++;

                } while (liczba % 2 != 0);

                Console.Write(liczba);

                if (i < n- 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("\nLiczba wykonanych losowań: " + licznik);
        }

        static void ZnajdzLiczbeParzystaB(int n)
        {
            Random random = new Random();

            int licznik = 0, liczba = 0;

            for (int i = 0; i < n; i++)
            {
                liczba = random.Next(-4, 5) * 2;
                licznik++;

                Console.Write(liczba);

                if (i < n - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("\nLiczba wykonanych losowań: " + licznik);
        }
    }
}
