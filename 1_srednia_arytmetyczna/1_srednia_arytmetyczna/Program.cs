using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_srednia_arytmetyczna
{
    class Program  {
        static void Main(string[] args)  {
            double a, b, c = 0;

            a = inputValue();
            b = inputValue();
            c = inputValue();

            double sredniaArytmetyczna;

            sredniaArytmetyczna = (a + b + c) / 3;
            Console.WriteLine(sredniaArytmetyczna);
        }

        private static double inputValue()    {
            double result;

            while (!double.TryParse(Console.ReadLine(), out result)) ;

            return result;
        }
    }
}
