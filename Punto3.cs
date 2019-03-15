using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_legendario
{
    class Punto3 : Punto2
    {
        public Punto3(double valor1, double valor2, double valor3, double valor4) : base(valor1, valor2, valor3, valor4)
        {
        }

        public override double CalcularPromedio()
        {

            return (v3+v4)/2;
        }
    }
}
