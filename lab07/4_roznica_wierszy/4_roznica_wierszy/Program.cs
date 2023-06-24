using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_roznica_wierszy
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size= 5;
            int[,] array = new int[size, size];

            Random random = new Random();

            Console.WriteLine("Tablica {0} x {0}: \n", size);

            for(int i = 0; i < size; i++)
            {
                Console.Write("{0}. ", i);
                for(int j = 0; j < size; j++)
                {
                    array[i, j] = random.Next(-20,21);
                    Console.Write("{0,4}", array[i, j]);
                }

                Console.WriteLine();
            }

            FindTheMostSimilarRows(array, out int row1, out int row2);

            Console.WriteLine($"\nNajbardziej podobne wiersze: {row1} i {row2}");

            Console.Read();
        }

        static void FindTheMostSimilarRows(int[,] array, out int row1, out int row2)
        {
            long minDiff = long.MaxValue;

            int nrOfRows = array.GetLength(0);
            int nrOfCol = array.GetLength(1);

            row1 = 0;
            row2 = 0;

            for(int i = 0; i < nrOfRows; i++)
            {
                for(int j = i + 1; j < nrOfRows; j++)
                {
                    long diff = CalculateDiff(array, i, j);

                    if(diff < minDiff)
                    {
                        minDiff = diff;
                        row1 = i;
                        row2 = j;
                    }
                }
            }
        }

        static long CalculateDiff(int[,] array, int i, int j)
        {
            int nrOfCol = array.GetLength(1);
            long diff = 0;

            for(int col = 0; col < nrOfCol; col++)
            {
                diff += (long)Math.Pow(array[i,col] - array[j,col], 2);
            }

            return diff;
        }
    }
}
