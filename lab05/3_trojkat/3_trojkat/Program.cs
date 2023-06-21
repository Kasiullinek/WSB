using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_trojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak wysoki trójkąt narysować?");
            int h = int.Parse(Console.ReadLine());

            int licznik = h;

            for (int i = 1; i <= h; i++)
            {
                for (int j = h-1; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("+");
                }
                Console.WriteLine("");
            }

            Console.Read();
        }
    }
}
