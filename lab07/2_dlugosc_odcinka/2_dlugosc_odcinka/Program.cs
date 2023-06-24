using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dlugosc_odcinka
{
    class Program
    {
        static void Main(string[] args)
        {
            double pX = 0, pY = 0, kX = 0, kY = 0;

            Console.Write("Podaj współrzędną X początkowego punktu: ");
            pX = double.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną Y początkowego punktu: ");
            pY = double.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną X punktu końca: ");
            kX = double.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną Y punktu końca: ");
            kY = double.Parse(Console.ReadLine());

            double length = CalculateLength(pX, pY, kX, kY);

            Console.WriteLine("\nDługość odcinka od punktu A({0},{1}) do punktu B({2},{3}) wynosi: {4}", pX, pY, kX, kY, length);

            Console.Read();
        }

        static double CalculateLength(double pX, double pY, double kX, double kY)
        {
            double length = Math.Sqrt(Math.Pow(kX - pX, 2) + Math.Pow(kY - pY, 2));
            return length;
        }
    }
}
