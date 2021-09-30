using System;

namespace PO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hombre mihombre = new Hombre(20);
            Hombre otro = new Hombre(20);
            // mihombre.P_peso = 50;
            // Console.WriteLine(mihombre.P_peso);




            Contador calculo = new Contador(-2);
           calculo.decrementar();
           Console.WriteLine(calculo);
        }

        
    }






    

    
}
