using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_potegowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, x, t = 1;

            Console.Write("Wpisz podstawe: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Wpisz wykladnik: ");
            x = int.Parse(Console.ReadLine());

            for(int i = 0; i < x; i++)
            {
                t *= a;
            }

            Console.WriteLine(a + " do potegi " + x + " = " + t);
            Console.ReadKey();
        }
    }
}
