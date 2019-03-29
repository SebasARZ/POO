using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLegendario
{
    class Generador
    {
        public double[] datos;
        static Random aleatorio = new Random();


        public Generador(int n)
        {
            datos = new double[n];
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = aleatorio.Next(1, 11);
            }
        }
        //Primera sobrecarga
        public Generador(int n, int a, int b)
        {
            datos = new double[n];
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = aleatorio.Next(a, b+1);
            }
        }
        //Segunda sobrecarga
        public Generador(double[] _datos)
        {
            datos = _datos;
        }
    }
}
