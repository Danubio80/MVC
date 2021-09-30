using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("escribe numero del mes");
            int numero = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(NombreMes(numero));
            }
            catch (Exception e)
            {
                Console.WriteLine("el mes esta fuera de rango");
              
            }

            Console.WriteLine("continua programa");
        }

        public static string NombreMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "enero";

                case 2:
                    return "febrero";

                default:
                    throw new Exception();



            }
        }

    }
}
