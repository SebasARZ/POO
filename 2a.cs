using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2a
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ax^2+cx+c, Ingrese a,b y c");

            double a;
            double b;
            double c;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            double discriminante = Math.Pow(b, 2) - (4 * (a * c));

            if(discriminante == 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("X1 = " + x1);
            }
            if (discriminante < 0)
            {
                Console.WriteLine("El ejercicio no tiene solución");
            }
            if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine("X1 =" + x1);
                Console.WriteLine("X2 =" + x2);
            }

        }
    }
}
