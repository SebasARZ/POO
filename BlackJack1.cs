using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int Jugador1 = 0;

            Random cartas = new Random();
            string respuesta = "s";

                int Carta = cartas.Next(1, 11);
                Jugador1 += Carta;
                int Carta2 = cartas.Next(1, 11);
                Console.WriteLine("Carta1 " + Carta);
                Jugador1 += Carta2;
                Console.WriteLine("Carta2 " + Carta2);
                Console.WriteLine("Total " + Jugador1);
                Console.WriteLine("Desea otra carta?");
                respuesta = Console.ReadLine();

            while (respuesta == "s" && Jugador1 <=21)
            {
                int Carta3 = cartas.Next(1, 11);
                Console.WriteLine("Carta = "+ Carta3);
                Jugador1 += Carta3;
                Console.WriteLine("Puntuacion" + Jugador1);

                if (Jugador1 < 21)
                {
                    Console.WriteLine("Desea otra carta?");
                    respuesta = Console.ReadLine();
                }
                if (Jugador1 > 21)
                {
                    Console.WriteLine("Ha perdido");
                }
                
            }

        }
    }
}
