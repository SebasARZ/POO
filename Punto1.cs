using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_legendario
{
    class Punto1
    {


        public int x;
        public static int y;


        public Punto1()
        {
            Punto4.EnConstruccion += RecepcionEvento;
        }
        public Punto1(int a, int b)
        {
            Punto4.EnConstruccion += RecepcionEvento;
        }
        public Punto1(string a)
        {
            Punto4.EnConstruccion += RecepcionEvento;
        }


        public void RecepcionEvento() {
            Console.WriteLine("Construido");
        }

    }    
}
