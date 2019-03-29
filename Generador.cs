using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro
{
    class Generador
    {
        public double[] datos;
        private double _resultado;
        static Random aleatorio = new Random();

                                                   

        public double resultado
        {
            get { return _resultado; }
        }

        public Generador(int n)
        {
          
            datos = new double[n];
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = aleatorio.Next(1,10);
            }
        }
        public virtual double Operar()
        {
            _resultado = 0;
            for (int i = 0; i < datos.Length; i++)
            {
                _resultado += datos[i];
            }
            return _resultado;
            
        }

    }
}
