using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;
            Console.Write("Podaj pierwszą liczbę: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz działanie:");
            Console.WriteLine("1 - dodawanie");
            Console.WriteLine("2 - odejmowanie");
            Console.WriteLine("3 - mnożenie");
            Console.WriteLine("4 - dzielenie");

            x = int.Parse(Console.ReadLine());

            switch(x)
            {
                case 1:
                    Console.WriteLine(a + " + " + b + " = " + (a + b));
                    break;
                case 2:
                    Console.WriteLine(a + " - " + b + " = " + (a - b));
                    break;
                case 3:
                    Console.WriteLine(a + " * " + b + " = " + (a * b));
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine(a + "/0");
                    }
                    else
                    {
                        Console.WriteLine(a + " / " + b + " = " + (a / b));
                    }
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
