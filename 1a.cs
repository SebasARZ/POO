using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1a
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 2;
            double z = 3;
            double t1 = (Math.Pow(y, 2)) + (Math.Pow(z, 2));
            double a1 = y / z;
            double c1 = z / y;

            double t = Math.Sqrt(t1);
            double a2 = Math.Atan(a1);
            double c2 = Math.Atan(c1);

            double c = c2 * (180 / Math.PI);
            double a = a2 * (180 / Math.PI);

            Console.WriteLine("a =" + a);
            Console.WriteLine("t =" + t);
            Console.WriteLine("c =" + c);
        }
    }
}
