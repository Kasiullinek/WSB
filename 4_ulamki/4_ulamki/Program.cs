using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ulamki
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, x, y;
          
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("d: ");
            d = int.Parse(Console.ReadLine());

            if (b == 0 || d == 0)
            {
                Console.WriteLine("b i d nie może być równe 0!");
            }else
            {
                y = b * d;
                x = (a * d) + (c * b);
                Console.WriteLine(x + "/"+ y + " = " + a + "/" + b + " + " + c + "/" + d);
            }

            Console.ReadLine();
        }
       
    }
}
