using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, h, bmi;

            Console.Write("Waga[kg]: ");
            w = inputValue();
            Console.Write("Wzrost[m]: ");
            h = inputValue();
            bmi = w / Math.Pow(h,2);
            Console.Write("BMI: " + bmi);
            Console.ReadKey();
        }
        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }
}

