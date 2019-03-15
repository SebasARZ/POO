using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_legendario
{
    class Punto2
    {
        protected double v1,v2,v3,v4;

        double V1 {
            get {
                return v1;
            }   
        }
        double V2 {
            get {
                return v2;
            }
            set {
                if (v2 <= 10) v2 = value ; 
            }
        }
            
        

        public Punto2(double valor1, double valor2, double valor3, double valor4)
        {
                v1 = valor1 ;
                v2 = valor2 ;
                v3 = valor3 ;
                v4 = valor4 ; 

        }
        public virtual double CalcularPromedio()
        {
            return (v1 +v2)/2;
        }
        

        
    }
  
}
