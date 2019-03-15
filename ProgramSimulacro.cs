using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_legendario
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto1 punto1 = new Punto1();
            Punto1 punto2 = new Punto1(3,2);
            Punto1 punto3 = new Punto1("Hola");

            punto1.x = 3;
            Punto1.y = 5;

            Punto2 p2 = new Punto2(1,2,3,4);

            double promedio = p2.CalcularPromedio();

            Console.WriteLine("Promedio Punto2 =" + promedio);


            

            Punto3 pu3 = new Punto3(3,2,1,4);

            double promedio2 = pu3.CalcularPromedio();

            Console.WriteLine("Promedio Punto2 =" + promedio2);

            Punto4 punt4 = new Punto4();
        }
         
    }
}
