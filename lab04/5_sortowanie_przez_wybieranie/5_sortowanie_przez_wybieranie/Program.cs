using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_sortowanie_przez_wybieranie
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

            for (int i = 0; i < rozmiar - 1; i ++)
            {
                int j = 0;
                int minIndex = i;

                for(j = i + 1; j < rozmiar; j++)
                {
                    if(tablica[j] < tablica[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = tablica[i];
                tablica[i] = tablica[minIndex];
                tablica[minIndex] = temp;

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
