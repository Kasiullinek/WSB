using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_sortowanie_babelkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 10;

            int[] tablica = new int[rozmiar];
            Random random = new Random();

            for (int i = 0; i < rozmiar; i++)
            {
                tablica[i] = random.Next(-10, 11);
            }

            Console.Write("Nieposortowana tablica: ");

            for (int i = 0; i < rozmiar; i++)
            {
                Console.Write(tablica[i] + " ");
               
            }

            for (int i = 0; i < rozmiar - 1; i++)
            {
                for (int j = 0; j < rozmiar - 1 - i; j++)
                {
                    if(tablica[j] > tablica[j+1])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
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
