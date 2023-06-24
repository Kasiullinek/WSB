using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_tablica_dwuwymiarowa_wezyk
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;

            do
            {
                Console.Write("Podaj rozmiar tablicy: ");
                size = int.Parse(Console.ReadLine());

            } while (size <= 0);

            int[,] array = new int[size, size];

            int currentRow = 0;
            int currentCol = 0;

            for (int currentNumber = 1; currentNumber <= size*size; currentNumber++ )
            {
                array[currentRow, currentCol] = currentNumber;

                if (currentRow % 2 == 0)
                {
                    if (currentCol + 1 >= size || array[currentRow, currentCol + 1] != 0)
                    {
                        currentRow++;
                    }
                    else
                    {
                        currentCol++;
                    }
                }
                else
                {
                    if (currentCol - 1 < 0 || array[currentRow, currentCol - 1] != 0)
                    {
                        currentRow++;
                    }
                    else
                    {
                        currentCol--;
                    }
                }
            }

            Console.WriteLine("\nTablica {0} x {0}: ", size);
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write("{0,4}", array[i,j]);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
