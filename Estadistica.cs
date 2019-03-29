using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro
{
    class Estadistica
    {
        

        double promedio;
        double[] datos;
        public Estadistica(double[] _datos)
        {
            datos = _datos ;
        }
        public Estadistica(Generador y)
        {
            datos = y.datos;
        }
        public double CalcularPromedio()
        {
            double suma = 0;
            for (int i = 0; i < datos.Length; i++)
            {
                suma += datos[i];
            }
            promedio = suma / datos.Length;
          
            return promedio;
            
        }
    }
}
