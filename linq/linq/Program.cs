using System;
using System.Collections.Generic;
using System.Linq;
namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {

            var coches = new List<Automovil>
    {
        new Automovil { Marca = "Renault", Modelo = "Clio"  , Carburante = TipoCarburante.Gasolina, Color = ConsoleColor.Green, potencia=50 },
        new Automovil { Marca = "Citroen", Modelo = "C3"    , Carburante = TipoCarburante.Diesel  , Color = ConsoleColor.Gray , potencia=20 },
        new Automovil { Marca = "Renault", Modelo = "Laguna", Carburante = TipoCarburante.Diesel  , Color = ConsoleColor.Black, potencia=80 },
        new Automovil { Marca = "Renault", Modelo = "Megane", Carburante = TipoCarburante.Gasolina, Color = ConsoleColor.Blue , potencia=90 },
        new Automovil { Marca = "Citroen", Modelo = "C4"    , Carburante = TipoCarburante.Gasolina, Color = ConsoleColor.Black, potencia=120 }
    };

            

            //queremos contar la cantidad de coches con potencia mayor de 50
            var coche = (from co in coches
                         where co.potencia > 50 select co).Count();


            var cochel = coches.Where(x => x.potencia > 50).Count();


            Console.WriteLine("dfd" + coche+ );
            //Buscar el coche con mayor potencia y menor

            var cochelento = coches.Where(x => x.potencia.



            //quisiéramos saber si todos los coches tienen más de 20 potencia

            var cocheg = from co in coches
                        group co by co.potencia into newli
                        orderby newli.Key
                        select newli;





            var consultaPotencia = (from coche in coches
                                    where coche.potencia > 50
                                    select coche).Count();
            Console.WriteLine($"Hay {consultaPotencia} con potencia mayor que 50");

            var cocheLento = coches.Where(x => x.potencia == coches.Min(y => y.potencia));
            Console.WriteLine(cocheLento.First().Modelo);

            var cocheRapido = coches.Where(x => x.potencia == coches.Max(y => y.potencia));
            Console.WriteLine(cocheRapido.First().Modelo);

            if (coches.All(coche => coche.potencia > 20))
            {
                Console.WriteLine("Todos los coches tienen una potencia mayor que 20");
            }
            else
            {
                Console.WriteLine($"{coches.Where(coche => coche.potencia <= 20).Count()} coches no tienen una potencia mayor que 20");
            }


            var querycoches = from c in coches
                              group c by c.Marca into grupomarca
                              orderby grupomarca.Key
                              select grupomarca;


            foreach (var marcas in querycoches)
            {
                Console.WriteLine($"Marca: {marcas.Key}");



                foreach (var coche in marcas)
                {
                    Console.WriteLine("Modelo: " + coche.Modelo + " Carburante: " + coche.Carburante);












                    int[] numeros = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };
            int[] arr4 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var micon = from nu in numeros
                         where nu > 7
                         orderby nu
                         select nu;

            var npar = from lis in arr1
                       where lis %2==0
                       select lis;
            foreach (var item in npar)
            {
                Console.WriteLine(item);
            }

            var resultado = n1.Where(c => c % 2 == 0);


            string[] nombres = { "Luis", "Pablo", "Susana", "María" };

            var nomn = from no in nombres
                       where no.Length >= 5
                       orderby no.Length
                       select no;




            List<string> animalNames = new List<string> { "fawn", "gibbon", "heron", "ibex", "jackalope" };
            var myquery3 = from ani in animalNames
                           where ani.Length >= 5
                           orderby ani.Length
                           select ani;



            foreach (var item in myquery3)
            {
                Console.WriteLine(item);
            }


            var rs = animalNames.Where(x => x.Length >= 5).OrderBy(x => x.Length);



            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };


            var nu = (from nus in arr1
                      where nus ==5
                      select nus).Count();

            var a = arr1.Count(a => a == 5);


            var a = arr1.Count(a => a == 7);
            Console.WriteLine("Aparece : " + a);
            var b = arr1.Count(a => a == 9);
            Console.WriteLine("Aparece : " + b);
            var c = arr1.Count(a => a == 1);
            Console.WriteLine("Aparece : " + c);




            

            List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3, 3.3 };
            Console.WriteLine(doubles.First());
            Console.WriteLine(doubles.Last());
            Console.WriteLine(doubles.ElementAt(2));
            Console.WriteLine(doubles.Count);
            Console.WriteLine(doubles.Average());
            Console.WriteLine(doubles.Min());
            Console.WriteLine(doubles.Max());
            Console.WriteLine(doubles.Sum());
            if (doubles.All(num => num > 2))
            {
                Console.WriteLine("Hay un valor menor que 2");
            }
            else
            {
                Console.WriteLine("Todso los valores son mayores que 2");
            }
            if (doubles.Any(num => num > 3))
            {
                Console.WriteLine("Hay un valor mayor que 3");
            }












        }
    }

    class Automovil
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public TipoCarburante Carburante { get; set; }
        public ConsoleColor Color { get; set; }
        public int potencia { get; set; }
    }
         public enum TipoCarburante
    {
        Gasolina,
        Diesel
    }





}