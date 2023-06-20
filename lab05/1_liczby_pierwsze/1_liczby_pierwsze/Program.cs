using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_liczby_pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, licznik = 0, liczba = 2;

            Console.WriteLine("Ile liczb pierwszych wyświetlić?");
            n = int.Parse(Console.ReadLine());

            Console.Write("\nLiczby pierwsze: \n");

            while (licznik < n) {

                bool t = true;

                for (int i = 2; i < liczba; i++)
                {
                    if(liczba % i == 0)
                    {
                        t = false;
                        break;
                    }
                }

                if(t)
                {
                    Console.WriteLine(liczba);
                    licznik++;
                }

                liczba++;
            }

            Console.Read();
        }
    }
}
