using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLegendario
{
    class PseudoEstadistica : Estadistica
    {
       public PseudoEstadistica(Generador generador) : base(generador)
       {

       }
        public override double Calcular()
        {
            double desviacion = 0;
            double sumatoria = 0;
            double prom = base.Calcular();

            for (int i = 0; i < Datos.Length; i++)
            {
                sumatoria += ( Datos[i] - prom);
            }
            desviacion = Math.Sqrt(sumatoria / Datos.Length);

            return desviacion;
        }
    }
}
