/*using System;
using System.Threading;
using System.Threading.Tasks;


class Ejercicio2 {


    static void Main() {
        
        string eleccion1 = "";
        string eleccion2 = "";

        var jugador1 = new Task(() => {
            Random random = new Random();
            string[] opciones = { "piedra", "papel", "tijera" };
            eleccion1 = opciones[random.Next(0, 3)];

            Console.WriteLine("Jugador 1 eligió: " + eleccion1);
        });


        var jugador2 = new Task(() => {
            Random random = new Random();
            string[] opciones = { "piedra", "papel", "tijera" };
            eleccion2 = opciones[random.Next(0, 3)];

            Console.WriteLine("Jugador 2 eligió: " + eleccion2);
        });

        jugador1.Start();
        jugador2.Start();

        Task.WaitAll(jugador1, jugador2);

        string resultado = ElegirGanador(eleccion1, eleccion2);
        Console.WriteLine("Resultado: " + resultado);

    

        static string ElegirGanador(string eleccionJugador1, string eleccionJugador2) {

            if (eleccionJugador1 == eleccionJugador2)
            {
                return "Empate";
            }
            else if (
                (eleccionJugador1 == "piedra" && eleccionJugador2 == "tijera") ||
                (eleccionJugador1 == "papel" && eleccionJugador2 == "piedra") ||
                (eleccionJugador1 == "tijera" && eleccionJugador2 == "papel")
            )
            {
                return "Jugador 1 gana. " + eleccionJugador1 + " mata " + eleccionJugador2;
            }
            else
            {
                return "Jugador 2 gana. " + eleccionJugador1 + " mata " + eleccionJugador2;
            }
        }

    }
}*/