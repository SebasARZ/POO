using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_legendario
{
    class Punto4
    {
        public delegate void Construccion();
        public static event Construccion EnConstruccion;

        public Punto4()
        {
            EnConstruccion(); 
        }

    }
}

