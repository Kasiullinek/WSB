using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 10;

            int[] tablica = new int[rozmiar];
            Random random = new Random();

            int min = tablica[0], max = tablica[0];

            for (int i = 0; i < rozmiar; i++)
            {
                tablica[i] = random.Next(-10, 11);
            }

            Console.Write("Tablica: ");

            for (int i = 0; i < rozmiar; i++)
            {
                Console.Write(tablica[i] + " ");
                if(tablica[i] <= min)
                {
                    min = tablica[i];
                }else if (tablica[i] >= max)
                {
                    max = tablica[i];
                }
            }

            Console.WriteLine("\n\nNajmniejszy element tablicy: " + min);
            Console.WriteLine("Największy element tablicy: " + max);

            Console.Read();
        }
    }
}
