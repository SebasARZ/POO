using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro
{
    class Program
    {
        static void Main(string[] args)
        {
            Generador[] generador = new Generador[3];
            Estadistica[] estadistica = new Estadistica[2];
            PseudoGenerador psudogenerador = new PseudoGenerador(3);


            for (int i = 0; i < generador.Length; i++)
            {
                generador[i] = new Generador(3);
                Console.WriteLine("Generador" + i);
                for (int j = 0; j < generador[i].datos.Length; j++)
                {
                    Console.WriteLine("Dato"+j+"="+generador[i].datos[j]);
                                        
                }
                double sumatoria = generador[i].Operar();
                Console.WriteLine("Sumatoria = " + sumatoria);
            }

            estadistica[0] = new Estadistica(new double[] { 3,2,4,5});
            double promedio0 = estadistica[0].CalcularPromedio();
            Console.WriteLine("Promedio de datos = " + promedio0);

            estadistica[1] = new Estadistica(generador[0].datos);
            double promedio1 = estadistica[1].CalcularPromedio();
            Console.WriteLine("Promedio datos generador[0]= " + promedio1);

            double multiplicacion = psudogenerador.Operar();
            Console.WriteLine("Multiplicaion = " + multiplicacion);
        }
    }
}
