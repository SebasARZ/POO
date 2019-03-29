using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro
{
    class PseudoGenerador : Generador
    {
        double multiplicacion = 1;
        public PseudoGenerador (int n) : base(n)
        {

        }

        public override double Operar() 
        {
            for (int i = 0; i < datos.Length; i++)
            {
                multiplicacion *= datos[i];

            }
            return multiplicacion;
        }
    }
}
