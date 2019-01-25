using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2c
{
    class Program
    {
        static void Main(string[] args)
        {
            double SMLMV = 828116;
            double Salario = double.Parse(Console.ReadLine());

            double A = 3200;
            double B = 12700;
            double C = 33500;

            if (Salario < SMLMV * 2)
            {
                double TarifaA = Salario * 0.115;
                Console.WriteLine("Su tarifa es Tipo A = $" +TarifaA);
                Console.WriteLine("y su cuota moderadora es de = $" + A);
            }
            if (Salario >= SMLMV * 2 && Salario < SMLMV * 5)
            {
                double TarifaB = Salario * 0.173;
                Console.WriteLine("Su tarifa es tipo B = $"+TarifaB );
                Console.WriteLine("y su cuota moderadora es de $" + B);
            }
            if (Salario >= SMLMV * 5)
            {
                double TarifaC = Salario * 0.23;
                Console.WriteLine("Su tarifa es tipo C = $" + TarifaC);
                Console.WriteLine("y su cuota moderadora es de = $" + C);
            } 
        }
    }
}
