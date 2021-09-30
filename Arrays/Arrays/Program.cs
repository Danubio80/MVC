using System;

namespace Arrays
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int[,] nuevo = new int[2, 2];

            for (int i = 0; i < nuevo.GetLength(0); i++)
            {
                for (int j = 0; j < nuevo.GetLength(1); j++)
                {
                    Console.WriteLine("dime tu numero:");
                    nuevo[i, j] = Convert.ToInt32(Console.ReadLine());
                    nuevo[i, j] = 3 * nuevo[i, j];
                }
            }

            for (int i = 0; i < nuevo.GetLength(0); i++)
            {
                for (int j = 0; j < nuevo.GetLength(1); j++)
                {
                    Console.WriteLine("los mumeros son" + nuevo[i, j]);
                }
            }




        }
    }
}
