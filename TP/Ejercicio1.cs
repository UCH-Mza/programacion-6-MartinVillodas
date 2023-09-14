/*
using System;
using System.Threading;
using System.Threading.Tasks;


class Ejercicio1 {

    static void Main() {
        
        var hilo1 = new Task(() => {
            for (int i = 0; i<10; i++){
                Console.WriteLine("Hilo1 "+i);
            }
        });

        var hilo2 = new Task(() => {
            for (int i = 0; i<10; i++){
                Console.WriteLine("Hilo2 "+i);
            }
        });

        var hilo3 = new Task(() => {
            for (int i = 0; i<10; i++){
                Console.WriteLine("Hilo3 "+i);
            }
        });

        var hilo4 = new Task(() => {
            for (int i = 0; i<10; i++){
                Console.WriteLine("Hilo4 "+i);
            }
        });

        var hilo5 = new Task(() => {
            for (int i = 0; i<10; i++){
                Console.WriteLine("Hilo5 "+i);
            }
        });
    
    
        hilo1.Start();
        hilo2.Start();
        hilo3.Start();
        hilo4.Start();
        hilo5.Start();
    }
}*/