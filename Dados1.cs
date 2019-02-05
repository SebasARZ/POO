using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //INICIO


            Random dado = new Random();

          

            int contador = 0;
            int contador2 = 0;
            int s = 0;
            int a = 0;

            Console.WriteLine("Presione s para inciar");
            string respuesta = (Console.ReadLine());

            while (respuesta == "s")
            {
                contador++;
                int dado1 = dado.Next(1, 7);
                int dado2 = dado.Next(1, 7);
                int total = dado1 + dado2;
                int acumulado = s + total;

                Console.WriteLine("Dado1 = " + dado1);
                Console.WriteLine("Dado2 = " + dado2);
                Console.WriteLine("Puntaje total = " + acumulado);

                s = acumulado;

                if (acumulado >= 100)
                {
                    Console.WriteLine("Ha ganado porque su puntaje llegó a 100");
                    break;
                }

                if (((dado1 == 1) && (dado2 == dado1)))
                {
                    Console.WriteLine("Ha perdido porque ha sacado 1 en los dos dados");
                    break;
                }
                if (dado1 == dado2) a ++;
                if (a >= 3)
                {
                    Console.WriteLine("Ha ganado por sacar 3 pares consecutivos");
                    break;
                }
                if (dado1 != dado2) a = 0;

                if (total >= 6)
                    contador2 ++;
                
                Console.WriteLine("¿Desea continuar?");
                respuesta = (Console.ReadLine());
            }
            double tan = ((double)contador2 / contador) * 100;
            Console.WriteLine("Su porcentaje cuando saco mas de 6 = " +  tan);
            Console.WriteLine("Fin del juego");

        }
    }
}
