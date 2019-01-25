using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = 3.61;
            double a = 33.69;
            double aRad = a*Math.PI/180;
            

            double z = Math.Cos(aRad) * t;
            double y = Math.Sqrt(Math.Pow(t, 2) - Math.Pow(z, 2));
            double c = 90 - a;

            Console.WriteLine("z = "+z);
            Console.WriteLine("y = " + y);
            Console.WriteLine("c = " + c);
        }
    }
}
