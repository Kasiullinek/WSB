using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_odwrocona_tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 10;

            int[] tablica = new int[rozmiar];
            Random random = new Random();

            for(int i = 0; i < rozmiar; i++)
            {
                tablica[i] = random.Next(0,11);
            }

            Console.Write("Pierwotna tablica: ");

            for (int i = 0; i < rozmiar; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            Console.Write("\nOdwrócona tablica: ");

            for (int i = (rozmiar-1); i >= 0; i--)
            {
                Console.Write(tablica[i] + " ");
            }

            Console.Read();
        }
    }
}
