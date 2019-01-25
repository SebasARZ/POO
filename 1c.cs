using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1c
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = 56.31;
            double z = 3;
            double cRad = c * Math.PI/180 ;

            double t = z / Math.Sin(cRad);
            double y = Math.Sqrt(Math.Pow(t, 2) - Math.Pow(z, 2));
            double a = 90 - c;

            Console.WriteLine("t = " + t);
            Console.WriteLine("y = " + y);
            Console.WriteLine("a = " + a);
        }
    }
}