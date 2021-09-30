using System;

namespace EjerciciosTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                string[][] empresa;

                Console.Write("Cuantas zonas tiene la empresa:");
                int zonas = int.Parse(Console.ReadLine());
                empresa = new string[zonas][];
                //f es una variable para recorrer las filas
                for (int z = 0; z < empresa.Length; z++)
                {
                    Console.Write("Cuantas comerciales tiene la zona " + z + ":");
                    int comerciales = int.Parse(Console.ReadLine());
                    empresa[zonas] = new string[comerciales];
                    
                }

                
                

                

                


            }



        }
}    }