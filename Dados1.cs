using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados1
{
    class Program
    {
        static void Main(string[] args)
        {
            //INICIO


            Random dado = new Random();

            int dado1 = dado.Next(1, 7);
            int dado2 = dado.Next(1, 7);

            int contador = 0;
            int contador2 = 0;
            int s = dado1 + dado2;

            Console.WriteLine("Su puntuacion es =" + s);
            Console.WriteLine("¿Desea continuar?");

            string respuesta = (Console.ReadLine());

            while(respuesta == "s")
            {
                int dado3 = dado.Next(1, 7);
                int dado4 = dado.Next(1, 7);
                int total = dado3 + dado4;
                int acumulado = s + total;

                Console.WriteLine("Dado1 = " + dado3);
                Console.WriteLine("Dado2 = " + dado4);

                s = acumulado;

                if (acumulado <= 100 || ((dado3 == 1) && (dado4 == dado3))) { Console.WriteLine("Ha perdido");
                    break;
                }
                int a = 0;
                while(dado3 == dado1)
                {
                    a++;
                }
                if (a >= 3) { Console.WriteLine("Ha ganado");
                    break;
                }
                if (total >= 6) contador2++;
                contador++;
            }Console.WriteLine("Fin del juego");
            double tan = contador2 / contador;
            Console.WriteLine("Su porcentaje cuando saco 6 =" + tan);

        }
    }
}
