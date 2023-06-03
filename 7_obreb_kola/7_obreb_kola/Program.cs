using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_obreb_kola
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, r, l, p;
            Console.Write("Podaj współrzędną x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną y: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Podaj promień r koła: ");
            r = double.Parse(Console.ReadLine());

            l = Math.Pow(x, 2) + Math.Pow(y, 2);
            p = Math.Pow(r, 2);

            if (l == p)
            {
                Console.WriteLine("Punkt (" + x +","+ y + ") leży w obrębie koła o środku O(0,0) i promieniu " + r );
            }
            else
            {
                Console.WriteLine("Punkt (" + x + "," + y + ") nie leży w obrębie koła o środku O(0,0) i promieniu " + r);
            }
            Console.ReadKey();
        }
    }
}
