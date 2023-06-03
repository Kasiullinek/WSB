using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_wieksza_liczba
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.Write("Podaj pierwszą liczbę: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            n2 = double.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("Większa jest: " + n1);
            } else if (n2 > n1)
            {
                Console.WriteLine("Większa jest: " + n2);
            } else
            {
                Console.WriteLine("Obie liczby są równe");
            }
            Console.ReadKey();
        }
    }
}
