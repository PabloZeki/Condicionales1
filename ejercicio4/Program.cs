using System;
//5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles 
//son mayores a 100.


namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float Numero1,Numero2,Numero3,Numero4;
            bool ban=false;
            
            Console.WriteLine("Ingrese un numero por favor:");
            Numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero por favor:");
              Numero2 = float.Parse(Console.ReadLine());
               Console.WriteLine("Ingrese un tercer numero por favor:");
                Numero3 = float.Parse(Console.ReadLine());
               Console.WriteLine("Ingrese un cuarto numero por favor:"); 
               Numero4 = float.Parse(Console.ReadLine());

               if(Numero1>100){
                Console.WriteLine( +Numero1);
                ban=true;
               } 
               if(Numero2>100){
                Console.WriteLine(+Numero2);
                ban=true;
               } 
               if (Numero3 > 100){
                Console.WriteLine( +Numero3);
                ban=true;
               }
                if (Numero4 > 100){
                Console.WriteLine(+Numero4);
                ban=true;
               }
               if(ban==false){
                Console.WriteLine("No se ingresaron numeros mayores a 100");
               }

        }
    }
}
