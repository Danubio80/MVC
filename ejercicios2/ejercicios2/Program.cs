using System;

namespace ejercicios2
{
    enum Razas { mongolico, americano, caucasico, malayo, etiopico };

    class Program
    {


        //public struct Paises
        //{
        //    string nombre;
        //    string capital;
        //    int numeroHabitantes;



        //}



        static void Main(string[] args)
        {

            //string[] ciudades;

            //Console.WriteLine("Dime nombre pais");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Nombre de capital");
            //string capital = Console.ReadLine();
            //Console.WriteLine("Numero de habitantes");
            //int habitantes = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("numero de Ciudades importantes");
            //int num = Convert.ToInt32(Console.ReadLine());
            //ciudades = new string[num];
            //for (int c = 0; c < ciudades.GetLength(0); c++)
            //{
            //    Console.WriteLine("dime su nombre");
            //    ciudades[c] = Console.ReadLine();
            //}

            //Console.WriteLine("dime raza habitantes");
            //string raza = Console.ReadLine();
            //int v = raza.CompareTo(Razas.americano);

            //int[][] empresa;

            //Console.Write("Cuantas zonas tiene la empresa:");
            //int zonas = int.Parse(Console.ReadLine());
            //empresa = new int[zonas][];
            ////f es una variable para recorrer las filas
            //for (int f = 0; f < empresa.GetLength(0); f++)
            //{
            //    Console.Write("Cuantas empleados tiene la zona " + f + ":");
            //    int empleados = int.Parse(Console.ReadLine());
            //    empresa = new int[empleados][];
            //    for (int i = 0; i < empleados; i++)
            //    {
            //        Console.WriteLine("Nombre");
            //        string nombre = Console.ReadLine();
            //        Console.WriteLine("ventas");
            //        int ventas = Convert.ToInt32(Console.ReadLine());

            //    }



            int[,] empresa;
            try
            {
                Console.WriteLine("Dame numero de empleados");
                int empleados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame zonas acivas");
                int zonas = Convert.ToInt32(Console.ReadLine());
                empresa = new int[empleados, zonas];
            }
            catch (Exception)
            {
                for (int i = 0; i < empresa.GetLength(0); i++)
                {
                    Console.WriteLine("Dame nombre empleado");
                    string nombre = Console.ReadLine();
                    for (int x = 0; x < empresa.GetLength(1); x++)
                    {
                        Console.WriteLine("Dame ventas zona " + (x + 1));

                        int ventas = Convert.ToInt32(Console.ReadLine());



                        for (int c = 0; c < empresa.GetLength(0); c++)
                        {
                            for (int z = 0; z < empresa.GetLength(1); z++)
                            {
                                empresa
        

                    }

                        }
            
           




                }

            }






       }
     }   
}
