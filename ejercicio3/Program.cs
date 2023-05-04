using System;
//3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada 
//según los siguientes valores:

//Si el importe es menor a ARS 1000, no hay descuento.
//Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
//Si el importe es ARS 5000 o más, aplica un descuento del 18%.

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)

        {
            float ImporteCompra,ImporteFinal=0;
            
            
            Console.WriteLine("Ingerese el importe de compra: ");
            ImporteCompra = float.Parse(Console.ReadLine());
            if(ImporteCompra <1000){
                ImporteFinal=ImporteCompra;
            } else
                if(ImporteCompra >=1000 && ImporteCompra < 5000){
                ImporteFinal=ImporteCompra*0.90f;
            }else {
           
            
                ImporteFinal=ImporteCompra*0.82f;
            }

             Console.WriteLine("El importe final es : " +ImporteFinal);

        }
    }
}
