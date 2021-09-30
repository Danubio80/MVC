using System;

namespace bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            //int contador = 0;
            //while (contador < 10)
            //{
            //    Console.WriteLine("Hola Mundo");
            //    contador++;
            //}

            //char letra = 'a';
            //while (letra<='z')
            //{
            //    Console.WriteLine(letra);
            //    letra++;
            //}

            //for (int i = 0; i < 100; i+=5)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;
            //while (i<100)
            //{
            //   Console.WriteLine(i);
            //   i += 5;
            //}


            //int num = 0;
            //do
            //{ 
            //    Console.WriteLine("Escribe un numero");
            //    num = Convert.ToInt32(Console.ReadLine());

            //} while ( num<0 || num>10);

            //double acumulador = 0;
            //int contador= 0;
            //double numero;
            //double promedio; 
            //do
            //{
            //    Console.WriteLine("Escribe un numero");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    acumulador = acumulador + numero;
            //    contador++;

            //} while (numero!=0);
            //promedio = acumulador / contador;
            //Console.WriteLine(promedio);

            //int contador = 0;
            //do
            //{
            //    char letra = 'a';
            //    while (letra <= 'z')
            //    {
            //        Console.Write(letra);
            //        letra++;

            //    }
            //    Console.WriteLine("");
            //    contador++;
            //} while (contador < 10);

            //int[] numeros = new int[12];
            //numeros[0] = 39;
            //numeros[1] = -2;

            //for (int i = 0; i < numeros.Length ; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            double[] numeros = new double[3];
            //Console.WriteLine("Escribe un numero");
            //numeros[0] = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Escribe un numero 2");
            //numeros[1] = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Escribe un numero 3");
            //numeros[2] = Convert.ToDouble(Console.ReadLine());
            //for (int i = 0; i <= numeros.Lenght; i++)
            //{
            //    tabla[i] = Convert.ToDouble(Console.ReadLine());

            //}
            //for (int i =0; )


            int[] miArray1 = new int[3];
            //Console.WriteLine("Introduce número 1");
            //miArray1[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce número 2");
            //miArray1[1] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce número 3");
            //miArray1[0] = int.Parse(Console.ReadLine());

            //for (int i = miArray1.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine("Introduce número " + (i + 1));
            //    miArray1[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < miArray1.Length; i++)
            //{
            //    Console.WriteLine("Nº " + i + " = " + miArray1[i]);
            //}

            //int[,] tabla = new int[2, 3];
            //for (int fila = 0; fila < tabla.GetLength(0); fila++)
            //{
            //    for (int columna = 0; columna < tabla.GetLength(1); columna++)
            //    {
            //        Console.WriteLine("dime un numero:");
            //        tabla[fila, columna] = Convert.ToInt32(Console.ReadLine());
            //    }


            //}
            //for (int fila = 0; fila < tabla.Length; fila++)
            //{
            //    for (int columna = 0; columna < tabla [fila].L; columna++)
            //    {
            //        Console.WriteLine(tabla[fila, columna]);

            //    }


            int[][] mat;
            Console.Write("Cuantas filas tiene la matriz:");
            int filas = int.Parse(Console.ReadLine());
            mat = new int[filas][];
            for (int fila = 0; fila < mat.Length; fila++)
            {
                Console.Write("Cuantos elementos tiene la fila" + fila + ":");
                int elementos = int.Parse(Console.ReadLine());
                mat[fila] = new int[elementos];

                for (int c = 0; c < mat[fila].Length; c++)
                {
                    Console.Write("Ingrese componente:");
                    mat[fila][c] = int.Parse(Console.ReadLine());
                }
            }
            for (int fila = 0; fila < mat.Length; fila++)
            {
                for (int columna = 0; columna < mat[fila].Length; columna++)
                {
                    Console.WriteLine(tabla[fila, columna]);


                }






    }




}
