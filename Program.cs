using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLegendario
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] daticos = new double[] { 3, 2, 3, 4 };
            double promedio = 0;

            Generador[] generador = new Generador[3];
            Estadistica[] estadistica = new Estadistica[2];

           generador[0] = new Generador(3);
           generador[1] = new Generador(3, 2, 3);
           generador[2] = new Generador(daticos);

            Console.WriteLine("Generador 0");
            for (int i = 0; i < generador[0].datos.Length; i++)
            {
                Console.WriteLine("Dato" + i + " = " + generador[0].datos[i]);
            }
            Console.WriteLine("Generador 1");
            for (int i = 0; i < generador[1].datos.Length; i++)
            {
                
                Console.WriteLine("Dato" + i + " = " + generador[1].datos[i]);
            }
            Console.WriteLine("Generador 2");
            for (int i = 0; i < generador[2].datos.Length; i++)
            {
               
                Console.WriteLine("Dato" + i + " = " + generador[2].datos[i]);
            }

            
            for (int i = 0; i < estadistica.Length; i++)
            {
                estadistica[i] = new Estadistica(generador[2]);    
            }
            for (int i = 0; i < estadistica[0].Datos.Length; i++)
            {
                Console.WriteLine("Dato Get = "+estadistica[0].Datos[i]);
            }
            promedio = estadistica[0].Calcular();
            Console.WriteLine("Promedio estadistica [0] = " + promedio);

        }
    }
}
