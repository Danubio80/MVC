using System;

namespace ejemplofinnally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\Users\danid\OneDrive\Escritorio\deli.txt";
                archivo = new System.IO.StreamReader(path);
                while ((linea = archivo.ReadLine())!= null)
                        {
                    Console.WriteLine(linea);
                    contador++;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error en lectura");
                
            }
            finally
            {
                if (archivo!=null)
                {
                    archivo.Close();
                    Console.WriteLine("conexion cerrada");
                }
            }

        }
    }
}
