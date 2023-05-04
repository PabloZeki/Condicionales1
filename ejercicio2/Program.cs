using System;

namespace ejercicio2
{
    class Program
    {
      //  2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” 
      //  si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” 
       // si el número es igual a cero.

        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("Ingrese un numero: ");
            Numero = int.Parse(Console.ReadLine());

            if(Numero==0){

                 Console.WriteLine("El numero es cero" );

            }else if(Numero>0){

                 Console.WriteLine("El numero es positivo ");

            }else{
                 Console.WriteLine("El numero es negativo");
            }
        }
    }
}
