using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLegendario
{
    class Estadistica
    {
        double[] _datos;
        public double[] Datos
        {
            get { return _datos; }
        }

        public Estadistica(Generador generador)
        {
           _datos = generador.datos;
        }

        virtual public double Calcular()
        {
            double suma = 0;
            for (int i = 0; i < _datos.Length; i++)
            {
               
                suma += _datos[i];
            }
            return suma / _datos.Length;
        }
    }
}
