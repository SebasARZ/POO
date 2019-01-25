using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            double SMLMV = 828116;
            double Salario = double.Parse(Console.ReadLine());

            if(Salario < SMLMV * 2)
            {
                Console.WriteLine("Su tarifa es tipo A");
            }
            if (Salario >= SMLMV * 2 && Salario < SMLMV*4)
            {
                Console.WriteLine("Su tarifa es tipo B");
            }
            if (Salario >= SMLMV * 4)
            {
                Console.WriteLine("Su tarifa es tipo C");
            }


              

        }
    }
}
