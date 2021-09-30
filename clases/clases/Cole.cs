using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    class Cole
    {
        public void MostrarList()
        {
            ////mas sencilla y mas usada.
            //List<int> listaenteros = new List<int>();
            //listaenteros.Add(6);
            //listaenteros.Add(4);

            //foreach (var item in listaenteros)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < listaenteros.Count; i++)
            //{
            //    Console.WriteLine(listaenteros[i]);
            //}

            //Queue<string> pepe = new Queue<string>();

            //Crea un List con los nombres de 6 compañeros de clase.A continuación, muestra esos nombres por pantalla. Utiliza para ello un bucle for que recorra todo el List

            List<string> compañeros = new List<string>();
            compañeros.Add("Osk");
            compañeros.Add("Guillermo");
            compañeros.Add("Yago");
            compañeros.Add("Christian");
            compañeros.Add("Jessi");
            compañeros.Add("Daniel");

            foreach (var item in compañeros)
            {
                Console.WriteLine();
            }

           // Crea una clase denominada Animal con los atributos especie(String), nombre(String), peso(double) y patas(int).


        }

        //  ArrayList obje new ArrayList();
        //  obje.Add(2);
        //  obje.Add(true);
        //  obje.Add("hola");
        //  foreach (var item in obje)
        //{
        //     Console.WriteLine();
        //}





    }
}
