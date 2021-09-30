using System;
using System.Collections;
using System.Collections.Generic;

namespace EjerciciosColecciones
{


    class Program


    {
        static void Main(string[] args)
        {
            //EJERCICIO1
            ArrayList nombres = new ArrayList();
            Console.WriteLine("Numero de participantes que quieres meter enla lista ?");
            int nele = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nele; i++)
            {
                Console.WriteLine("Escribe nombre please");
                nombres.Add(Console.ReadLine());

            }

            Console.WriteLine("Lista de nombres en lista");

            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Indicame a que posicion quieres acceder");

            int posicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El elemento {0} is \"{1}\"", posicion, nombres[posicion]);

            Console.WriteLine(" ");
            Console.WriteLine("Indicame nombre para introducir en 2 posicion");
            nombres[2] = Console.ReadLine();
            Console.WriteLine(" ");
            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Introduce elemento a buscar");
            string busco = Console.ReadLine();
            for (int i = 0; i < nombres.Count; i++)
            {
                if (busco == (string)nombres[i])
                {
                    Console.WriteLine(nombres[i] + " esta en la lista");
                }
            }
            Console.WriteLine(" ");

            Console.WriteLine("Ordenar nombres alfabeticamente");
            nombres.Sort();
            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Borrar segundo elemento");
            nombres.RemoveAt(1);
            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Mostrar capacidad y count");

            int count = nombres.Count;
            int capacity = nombres.Capacity;
            Console.WriteLine("El array tiene una capacidad de {0} y un count de {1} ", capacity, count);


            nombres.TrimToSize();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Mostrar capacidad y count");

            count = nombres.Count;
            capacity = nombres.Capacity;
            Console.WriteLine("El array tiene una capacidad de {0} y un count de {1} ", capacity, count);


            //EJERCICIO2
            Queue<Mensaje> cola = new Queue<Mensaje>();

            Mensaje primero = new Mensaje(1, "uno");
            Mensaje segundo = new Mensaje(2, "dos");
            Mensaje tercero = new Mensaje(3, "tres");
            cola.Enqueue(primero);
            cola.Enqueue(segundo);
            cola.Enqueue(tercero);

            char salir;
            do
            {
                Console.WriteLine("COLA");
                Console.WriteLine("Elige opcion a ralizar:");
                Console.WriteLine("1-Enumerar los mensajes existentes\n2-Quitar de la cola el primer mensaje\n3-Borrar todos los mensajes");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enumeración de los mensajes existentes");
                        foreach (var item in cola)
                        {
                            Console.WriteLine(item.P_ide + " " + item.P_texto);
                        }

                        break;

                    case 2:
                        Console.WriteLine("Eliminación del mensaje mas antiguo");
                        cola.Dequeue();
                        foreach (var item in cola)
                        {
                            Console.WriteLine(item.P_ide + " " + item.P_texto);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Borrando lista ..");
                        cola.Clear();
                        foreach (var item in cola)//no debe mostrar elementos.
                        {
                            Console.WriteLine(item.P_ide + " " + item.P_texto);
                        }
                        Console.WriteLine("-Lista borrada-");
                        break;

                }
                Console.WriteLine("Si pulsas la tecla q saldras del menu, pulsa la tecla c para continuar");
                salir = Convert.ToChar(Console.ReadLine());
            } while (salir != 'q');




            //EJERCICIO2
            Dictionary<string, string> traductor = new Dictionary<string, string>();
            Console.WriteLine("DICCIONARIO");
            Console.WriteLine("Introduce palabra en español y su traducción.");
            char salir;
            do

            {
                Console.Write("Palabra en español: ");
                string esp = Console.ReadLine();
                Console.Write("Traducíón al ingles: ");
                string ing = Console.ReadLine();
                traductor.Add(esp, ing);
                Console.WriteLine("Para terminar pulsa tecla 's',para continuar pulsa otra tecla");
                salir = Convert.ToChar(Console.ReadLine());
            } while (salir != 's');

            Console.WriteLine("Introduce palabra a traducir");
            string espt = Console.ReadLine();
            Console.WriteLine("La traduccion de {0} es {1}.", espt, traductor[espt]);



            //EJERCICIO 3
            List<Animal> lista1 = new List<Animal>();
            Animal leon = new Animal("leon", 100, 4);
            Animal elefante = new Animal("Elefante", 500, 4);
            Zoo madrid = new Zoo();

            madrid.AñadirAnimal(elefante);
            madrid.AñadirAnimal(leon);
            
            foreach (var item in lista1)
            {
                Console.WriteLine(item.Nombre);

            }

            Console.WriteLine("buscar animal");
            string busqueda = Console.ReadLine();


            bool existe = lista1.Exists(x => x.Nombre == busqueda);
            if (existe == true)
            {
                Console.WriteLine("El animal {0} existe en la lista", busqueda);
            }
            else { Console.WriteLine("El animal no esta en la lista"); }

        }

        

    }

}
