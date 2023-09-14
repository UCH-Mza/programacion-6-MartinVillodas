
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Ejercicio3{
    static async Task Main(){
        // Crear una lista para almacenar tareas que devuelven valores enteros
        List<Task<int>> tareas = new List<Task<int>>();

        // Llenar la lista con 5 tareas de GenerarYCalcularSumaAsync
        for (int i = 0; i < 5; i++){
            tareas.Add(GenerarYCalcularSumaAsync());
        }

        // Esperar a que todas las tareas finalicen y obtener los resultados
        int[] resultados = await Task.WhenAll(tareas);

        Console.WriteLine("Resultados de las sumatorias individuales:");

        for (int i = 0; i < resultados.Length; i++){
            Console.WriteLine($"Conjunto {i + 1}: {resultados[i]}");
        }

        // Calcular la suma total de todos los conjuntos
        int sumaTotal = resultados.Sum();
        Console.WriteLine($"Suma total de todos los conjuntos: {sumaTotal}");
    }

    static async Task<int> GenerarYCalcularSumaAsync(){
        // Crear un generador de números aleatorios
        Random aleatorio = new Random();
        List<int> numerosAleatorios = new List<int>();

        // Generar 1000 números aleatorios y agregarlos a la lista
        for (int i = 0; i < 1000; i++){
            int numeroAleatorio = aleatorio.Next(101); // Números entre 0 y 100
            numerosAleatorios.Add(numeroAleatorio);
        }

        // Calcular la suma de los números aleatorios utilizando CalcularSumaAsync
        int suma = await CalcularSumaAsync(numerosAleatorios);
        return suma;
    }

    public static Task<int> CalcularSumaAsync(List<int> numeros){
        // Ejecutar el cálculo de la suma en un nuevo hilo usando Task.Run
        return Task.Run(() => {
            int suma = numeros.Sum();
            return suma;
        });
    }
}