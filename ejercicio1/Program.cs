using System;

namespace _1
{
    class Program
    {
       // 1. Hacer un programa para ingresar un número y luego se emita por pantalla un 
        // cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

        static void Main(string[] args)
        {
           int Numero;

            Console.WriteLine("Ingrese un numero: ");

            Numero = int.Parse(Console.ReadLine());

            if(Numero > 10){

                Console.WriteLine("Es mayor a 10");
            }
            else{
                Console.WriteLine( "No es mayor a 10");
            }
           
        }
    }
}
