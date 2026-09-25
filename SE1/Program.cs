using System;

namespace SE1
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Sesion 10: Solucion de Examen
        6. Operadores aritmeticos*/
        double operacion = 0;
        operacion = (( 30 + 8 - 2 )) * -1;
        Console.WriteLine($"El resultado de la operacion es: {operacion}");
        // sesion 11: 
        // 7. Interruptores
        bool interruptor_1 = false;
        bool interruptor_2 = true;
        bool bombilla = false;
        if (interruptor_1  && interruptor_2 )
        {
            bombilla = true;
                
        }
        else
        {
            bombilla = false;
        }
        Console.WriteLine($"El estado de la bombilla es: {bombilla}");
        // 8. asueto 
        int dia = 16;
        string mes = "septiembre";
        if (dia == 16 && mes == "septiembre")
            {
                Console.WriteLine("¡Hoy es asueto!");
            }
        else
            {
                Console.WriteLine("Sin definir");
            }
            // 9. 
            bool resukltadob = (7 < 11) && 9 != 0; 
            Console.WriteLine($"Expresion: {resukltadob}");

        }
    }
}   