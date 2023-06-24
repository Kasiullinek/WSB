using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_formatowanie_czasu
{
    class Program
    {
        static void Main(string[] args)
        {
            long time = 0;

            do
            {
                Console.WriteLine("Ile czasu upłynęło od godzinny 00:00:00? Czas podaj w sekundach!");
                time = long.Parse(Console.ReadLine());
            } while (time < 0);

            FormatTime(time);

            Console.Read();
        }

        static void FormatTime(long time)
        {
            long h = time / 3600;

            time -= h * 3600;

            long m = time / 60;

            time -= m * 60;

            Console.Write("\nCzas: ");
            if(h < 9)
            {
                Console.Write("0{0}:", h);
            }else
            {
                Console.Write("{0}:", h);
            }

            if (m < 9)
            {
                Console.Write("0{0}:", m);
            }
            else
            {
                Console.Write("{0}:", m);
            }

            if (time < 9)
            {
                Console.Write("0{0}", time);
            }
            else
            {
                Console.Write("{0}", time);
            }
        }
    }
}
