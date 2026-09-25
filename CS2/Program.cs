using System;
// Espacio de nombres 
namespace CS2
{
    // Clase principal
    class Program
    {
        // Función principal
        static void Main(string[] args)
        {
            // Sesion 5; Tipos de datos
            // Sintaxis para declarar variables
           // TipoDato identificador_variable;
            // 1. Entero
            int a;
            // 2. cadena de texto
            string s;
            // 3. flotantes (precision sencilla)
            float f;
            // 3.2 flotantes (precision doble)
            double d;
            // 4. booleano (logico)
            bool b;
            // inicializanciones 
            a = 5;
            s = "Exactas";
            f = 8.5f;
            d = 9.5;
            b = true;
            // Palabra reservada: Identificador especial predefinido para el copilador.
            // interpolacion: Combinacion de datos dentro de una cadena.
            // Impresiones
            Console.WriteLine($"Entero: {a}");
            Console.WriteLine($"String: {s}");
            Console.WriteLine($"Flotante (simple): {f}");
            Console.WriteLine($"Flotante (doble): {d}");
            Console.WriteLine($"Booleano: {b}");
        } // Termina la función principal
    } // Termina la clase principal
} // Termina el espacio de nombres

