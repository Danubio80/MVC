using System;
using System.Collections;
using System.Collections.Generic;

namespace clases
{
   public delegate int Operaciones(int a, int b);
    class Program
    {
      static public  int Suma(int a,int b)
        {
            return a + b;
        }

        static public int Resta(int a, int b)
        {
            return a - b;
        }
        
               
        static void Main(string[] args)
        {
            Operaciones miop = Suma;
            int mivar = miop(4, 6);

            Operaciones resta = new Operaciones(Resta);

            //    //Clase program dentro del main:
            //    //EJERCICIO 3
            //    List<Animal> listaAnimales = new List<Animal>();
            //    listaAnimales.Add(new Animal("Mamifero", "Perro", 15.25, 4));
            //    listaAnimales.Add(new Animal("Mamifero", "Gato", 5.75, 4));
            //    listaAnimales.Add(new Animal("Mamifero", "Oso", 150.25, 4));
            //    listaAnimales.Add(new Animal("Mamifero", "Mono", 55.25, 4));

            //    Console.WriteLine("Total de animales en la lista: " + listaAnimales.Count);
            //    for (int i = 0; i < listaAnimales.Count; i++)
            //    {
            //        Console.WriteLine(i + " " + listaAnimales[i].ToString());
            //    }

            //    Console.WriteLine("Introduce numero de animal que desea eliminar:");
            //    int num = int.Parse(Console.ReadLine());

            //    listaAnimales.RemoveAt(num);

            //    Console.WriteLine("Total de animales en la lista: " + listaAnimales.Count);
            //    for (int i = 0; i < listaAnimales.Count; i++)
            //    {
            //        Console.WriteLine(i + " " + listaAnimales[i].ToString());



            //    }


            //    Dictionary<int, Animal> diclist = new Dictionary<int, Animal>();
            //    diclist.Add(1, new Animal("mamifero", "perro", 34.3, 4));
            //    diclist.Add(2, new Animal("mamifero", "perro", 34.3, 4));
            //    foreach (var item in diclist)
            //    {
            //        Console.WriteLine(item.Key);
            //        Console.WriteLine(item.Key.);
            //    }

            //   /* un delegado recibe parametros dos enteros
            //        devuelve un entero
            //        dos metodos sumar y restar*/

            Fun
0
        }



        }
}
