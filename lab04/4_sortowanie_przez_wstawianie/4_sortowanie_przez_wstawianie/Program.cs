using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_sortowanie_przez_wstawianie
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 10;

            int[] tablica = new int[rozmiar];
            Random random = new Random();

            Console.Write("Nieposortowana tablica: ");

            for (int i = 0; i < rozmiar; i++)
            {
                tablica[i] = random.Next(-10, 11);
                Console.Write(tablica[i] + " ");
            }

            for (int i = 0; i < rozmiar; i++)
            {
                int wskaznik = tablica[i];
                int j = i - 1;

                while (j >= 0 && tablica[j] > wskaznik)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                }

                tablica[j + 1] = wskaznik;
            }

            Console.Write("\n\nPosortowana tablica: ");

            for (int i = 0; i < rozmiar; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            Console.Read();
        }
    }
}
