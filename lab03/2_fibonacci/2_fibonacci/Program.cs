using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n = 0;
                long a = 1, b = 1, temp = 0;

                Console.Write("Wpisz ile kolejnych wyrazów ciągu Fibonacciego wyświetlić: ");
                n = int.Parse(Console.ReadLine());

                if (n < 3 && n > 0)
                {
                    Console.Write("Ciąg Fibbonaciego: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("1 ");
                    }
                }
                else if (n <= 0)
                {
                    Console.Write("Ciąg nie istnieje dla wybranej wartości");
                }
                else
                {
                    Console.Write("Ciąg Fibbonaciego: 1 1 ");
                    for (int i = 3; i <= n; i++)
                    {
                        temp = b;
                        b += a;
                        a = temp;
                        Console.Write(b + " ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Naciśnij Escape aby zakończyć działanie programu lub dowolny klawisz aby kontynuować...");
                Console.WriteLine();

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
