/*
using System;
using System.Threading.Tasks;

class Ejercicio4{
    static async Task Main(){
        //Hago una tarea para representar el proceso
        Task procesoTask = Proceso.EjecutarAsync();
        Task barraEstadoTask = MostrarBarraEstadoAsync();

        //Espero a que ambas tareas terminen
        await Task.WhenAll(procesoTask, barraEstadoTask);

        Console.WriteLine("Proceso completado.");
    }

    static async Task MostrarBarraEstadoAsync(){
        Console.WriteLine("Barra de Estado:");

        //simulo la barra de estado
        for (int i = 0; i <= 100; i ++){
            Console.Write($"[{i}%] ");
            await Task.Delay(100); 
        }
    }
}

class Proceso{
    public static async Task EjecutarAsync(){
        Console.WriteLine("Proceso ejecutandose:");

        for (int i = 0; i <= 100; i++){
            Console.WriteLine($"Paso {i}");
            await Task.Delay(100);
        }
    }
}
*/