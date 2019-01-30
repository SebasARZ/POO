using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea30._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese votos del partido 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese votos del partido 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de poblacion");
            int poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de la poblacion apto para votar"); 
            double p = double.Parse(Console.ReadLine()) * poblacion;
            int total = a + b + blancos + anulados;

            if(total > poblacion || (a-b)< total*0.1 && p < poblacion * 0.3)
            {
                Console.WriteLine("deben hacerse otras elecciones");
            }
            else{
                if (a > b)
                {
                    Console.WriteLine("el ganador es a");
                }else
                {
                    Console.WriteLine("el ganador es b");
                }


                /* Tabla de verdad: 
                   000 = 0 
                   001 = 0
                   010 = 0
                   011 = 1
                   100 = 0
                   101 = 1
                   110 = 0
                   111 = 1
                */
            }



           



        }
    }
}
