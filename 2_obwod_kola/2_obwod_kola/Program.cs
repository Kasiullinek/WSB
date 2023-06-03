using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_obwod_kola
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, r, o;

            p = (double)inputValue();
            r = (double)Math.Sqrt( p/ Math.PI);
            o = (double)(2 * Math.PI * r);
            Console.WriteLine(o);
        }

        private static double inputValue()
        {
            double result;

            while (!double.TryParse(Console.ReadLine(), out result)) ;

            return result;
        }
    }
}
