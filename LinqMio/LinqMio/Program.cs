using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqMio
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] temperaturas = { 21.2, 22.5, 33.5, 55.5 };
            double primero = temperaturas.First();
            var temperaturaalta = temperaturas.Where(p => p > 33);

            foreach (var item in temperaturaalta)
            {
                Console.WriteLine(item);
            }





            var db = new Database();
            var misprofes = from d in db.Profesores
                            where d.edad < 100
                            select d;

            var consulta = from p in db.libritos
                           select new { p.nombre, p.autor };


            //var personasLambda = db.Profesores.Where(p=>p.edad==32);

            //foreach (var item in personasLambda)
            //{
            //    Console.WriteLine(item.nombre);
            //}

               
            
            










                          
        }

        

    }
}
