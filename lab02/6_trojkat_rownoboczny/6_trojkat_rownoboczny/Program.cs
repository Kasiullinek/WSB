using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_trojkat_rownoboczny
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Podaj bok a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Podaj bok b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Podaj bok c: ");
            c = double.Parse(Console.ReadLine());

            if ((a == b) && (a == c))
            {
                Console.WriteLine("Trójkąt jest równoboczny");
            }else
            {
                Console.WriteLine("Trójkąt nie jest równoboczny");
            }
            Console.ReadKey();
        }
    }
}
