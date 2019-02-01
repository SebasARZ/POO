using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 2; i++)
            {

                Random random = new Random();
                int a = random.Next(0, 11);
                int b = random.Next(0, 11);

                int capcha = a + b;

                Console.WriteLine("Cuanto es: a+b");
                Console.WriteLine("a =" + a);
                Console.WriteLine("b =" + b);

                int correcto = int.Parse(Console.ReadLine());

                if (correcto == capcha)
                {
                    Console.WriteLine("Puede continuar");
                    break;

                }
                if (i >= 2) Console.WriteLine("No tiene mas intentos");
            }

            

        }
    }
}
