using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPost2
{

    class MainClass
    {

        public static void Main(string[] args)
        {

            grup();
        }
        public static void proye()
        {

            var dbalu = new FakeDatabase();





            //Llmada a la clase que trae los  datos
            var db = new FakeDatabase();

            var misalumnos =from l in db.Teachers
           
            //// ordena los resultados filtrados de profesores
            var micon = from d in db.Teachers
                        where d.Age > 40
                        orderby d.Age
                        select d;
           



            //select que devuelve un tipo anonimo
            var personasConsulta = from p in db.Lectures
                                   select new { p.Name, p.TeacherId };
         

            ///Lo mismo con Lambda
            var personasLambda = db.Lectures.Select(p => new { p.Name, p.TeacherId });
            //Recorro con un foreach
            foreach (var persona in personasConsulta) 
            {
                Console.WriteLine("{0} - {1}", persona.Name, persona.TeacherId);
            }



            





            var mm = db.Teachers.Count();
            Console.WriteLine(mm);
        }


        //Agrupar
        #region Count
        public static void agrup()
        {
            double[] temperaturas = { 72.0, 81.5, 69.3, 88.6, 80.0, 68.5 };
            var promedio = temperaturas.Average();




            Console.WriteLine("Promedio: {0}", promedio);

            int mayores80 = temperaturas.Count(t => t > 80);
            Console.WriteLine("Mayores de 80°: {0}", mayores80);

            double maxima = temperaturas.Max();
            Console.WriteLine("Máxima: {0}", maxima);

            double minima = temperaturas.Min();
            Console.WriteLine("Mínima: {0}", minima);

            double suma = temperaturas.Sum();
            Console.WriteLine("Mínima: {0}", suma);

           

            var db = new FakeDatabase();
            Console.Write(Environment.NewLine);
            //contar la cantidad de profesores cuyo nombre comienza con L
            var profesoresConL =
                db.Teachers.Count(p => p.GivenName.StartsWith("L"));

            double mioo = db.Lectures.Count();
                

            Console.Write("Profesores con L : " + profesoresConL);
            Console.Read();


            #region Sum
            Console.Write(Environment.NewLine);

            //Cuantos años en total suman los profesores que tienen menos de 30
            var menosDe30Total = db.Teachers
                .Where(t => t.Age < 30)
                .Sum(t => t.Age);

            #endregion


            var menosDe30Total1 = (from t in db.Teachers
                                   where t.Age < 30
                                   select t.Age).Sum();

            Console.Write("Suma de las edades de profesores menores a 30: " + menosDe30Total + " | " + menosDe30Total1);

            Console.Read();
            #region Min y Max
            //No todos los profesores tienen correo electrónico, ¿tendrá algo que ver con la edad? 
            //con los métodos Min y Max podemos obtener los valores máximos y mínimos dentro de 
            //un conjunto de resultados:
            Console.Write(Environment.NewLine);
            var edadMinSinEmail = (from t in db.Teachers
                                   where t.Email == ""
                                   select t).Min(t => t.Age);

            var edadMaxSinEmail = db.Teachers
                .Where(t => t.Email != "")
                .Max(t => t.Age);

            Console.WriteLine("Edad mínima " + edadMinSinEmail + ", edad máxima " + edadMaxSinEmail);
            #endregion

            #region Average
            Console.Write(Environment.NewLine);
            var promedioEdadSMail = (from t in db.Teachers
                                     where t.Email == ""
                                     select t).Average(t => t.Age);

            var promedioEmailCMail = db.Teachers
                .Where(t => t.Email != "")
                .Average(t => t.Age);

            Console.WriteLine("Edad promedio sin mail " + promedioEdadSMail + ", promedio edad con email " + promedioEmailCMail);
            #endregion

            #region All
            Console.Write(Environment.NewLine);
            // quisiéramos saber si todos los maestros tienen más de 18 años:
            var todosMayores = db.Teachers.All(teacher => teacher.Age > 18);
            var mio = db.Teachers.All(m => m.LastName.Length > 4);
            Console.WriteLine((todosMayores ? "Todos " : "No todos ") + "los maestros son mayores");
            #endregion

            #region Any
            //si queremos saber si existe algún maestro que se llame Cosme Fulanito
            bool existeCosmeFulanito = db.Teachers.Any(teacher => teacher.GivenName == "Cosme"
                                      && teacher.LastName == "Fulanito");

            Console.WriteLine((existeCosmeFulanito ? "Existe " : "No existe ") + "Cosme Fulanito");

            bool hayClases = db.Lectures.Any();
            Console.WriteLine(hayClases ? "Hay clases, yay! " : "No hay clases :( :(");
            #endregion


            


            #endregion

        }
        public static void grup()
        {
            var db = new FakeDatabase();
            //group permite agrupar los resultados basados en Age
            //crea un nuevo  grupo llamado newGroup Agrupados que es una coleccion de profesores
            //agrupados por edad
            var queryLastNames = from tea in db.Teachers
            group tea by tea.Age into newGroup
            orderby newGroup.Key
            select newGroup;

            //for para cada grupo newGroup
            foreach (var nameGroup in queryLastNames)
            {
                Console.WriteLine($"Key: {nameGroup.Key}");
                //for para  cada nameGrroup  dentro de newGroup
                foreach (var student in nameGroup)
                {
                    Console.WriteLine($"\t{student.LastName}, {student.GivenName}");
                }
            }

            Console.Read();





            // Nested grouping:

            var groupedLecturesPerLevelAndTeacher =
                from lecture in db.Lectures
                group lecture by lecture.TeacherId into group1
                select new
                {
                    TeacherId = group1.Key,
                    Levels = from level in group1
                             group level by level.Level into group2
                             select new
                             {
                                 LevelName = group2.Key,
                                 Lectures = group2.ToList()
                             }
                };

            Console.WriteLine("Lectures per level and teacher:");
            foreach (var teacherLevel in groupedLecturesPerLevelAndTeacher.Take(5))
            {
                Console.WriteLine("Profe Id: " + teacherLevel.TeacherId + ": ");
                foreach (var levelClass in teacherLevel.Levels)
                {
                    Console.WriteLine("\t" + levelClass.LevelName + ": ");
                    foreach (var @class in levelClass.Lectures)
                    {
                        Console.WriteLine("\t\t" + @class.Name);
                    }
                }
            }
            Console.Read();
        }

        public static void parit()
        {

            double[] temperaturas = { 72.0, 81.5, 69.3, 88.6, 80.0, 68.5 };
            double primero = temperaturas.First();
            Console.WriteLine("Primero: {0}", primero);

            double ultimo = temperaturas.Last();
            Console.WriteLine("Último: {0}", ultimo);

            var skip = temperaturas.Skip(3);
            Console.Write("Omite los primeros 3: ");


            var take = temperaturas.Take(5);
            Console.Write("Toma los primeros 5: ");


            var db = new FakeDatabase();
            // take 
            //Obtendremos los cinco primeros elementos de la consulta
            var maestk = (from mt in db.Teachers
                          select mt).Take(4);
        
            var cincoMenores20 = (from t in db.Teachers
                                  where t.Age < 20
                                  orderby t.Age
                                  select t).Take(5);
            //skip Si quisiéramos recuperar los maestros sin tener en cuenta los 4 primeros
            var mismaestros = db.Teachers.Skip(4);
            var otrosMaestros = db.Teachers
    .Where(t => t.Age > 30)
    .OrderByDescending(t => t.Age)
    .Skip(4);

            var q6 = from l in db.Teachers
                     orderby l.LastName descending
                     select l;
            // First Si queremos obtener el primer maestro:
            var maestro1 = q6.First();
            Console.WriteLine("Maestro " + maestro1.GivenName + " " + maestro1.LastName);

            try
            {
                var cosmeFulanito = q6.First(m => m.GivenName == "Cosme" && m.LastName == "Fulanito");
                Console.WriteLine("Maestro " + cosmeFulanito.GivenName + " " + cosmeFulanito.LastName);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }


            var cosmeFulanito2 = q6.FirstOrDefault(m => m.GivenName == "Cosme" && m.LastName == "Fulanito");
            if (cosmeFulanito2 != null)
            {
                Console.WriteLine("Maestro " + cosmeFulanito2.GivenName + " " + cosmeFulanito2.LastName);
            }
            else
            {
                Console.WriteLine("No existe el maestro Cosme Fulanito");
            }

            // Single
            //var maestro3 = q6.Single(); // Excepción porque q6 contiene más de 1 elemento
            //Console.WriteLine("Maestro " + maestro3.GivenName + " " + maestro3.LastName);

            try
            {
                var cosmeFulanito = q6.Single(m => m.GivenName == "Cosme" && m.LastName == "Fulanito");
                Console.WriteLine("Maestro " + cosmeFulanito.GivenName + " " + cosmeFulanito.LastName);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }


            var cosmeFulanito3 = q6.SingleOrDefault(m => m.GivenName == "Cosme" && m.LastName == "Fulanito");
            if (cosmeFulanito3 != null)
            {
                Console.WriteLine("Maestro " + cosmeFulanito3.GivenName + " " + cosmeFulanito3.LastName);
            }
            else
            {
                Console.WriteLine("No existe el maestro Cosme Fulanito");
            }

            // ElementAt
            var maestroSegundo = q6.ElementAt(2);
            Console.WriteLine("Segundo maestro: " + maestroSegundo.GivenName + " " + maestroSegundo.LastName);

            var maestroDecimo = q6.ElementAt(10);
            Console.WriteLine("Décimo maestro: " + maestroDecimo.GivenName + " " + maestroDecimo.LastName);

            try
            {
                var maestroNoningentesimo = q6.ElementAt(900); // Excepción ¡porque q6 no tiene 900 maestros!
                Console.WriteLine("Noningentésimo maestro: " + maestroNoningentesimo.GivenName + " " + maestroNoningentesimo.LastName);

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("No hay 900 maestros :(");
            }



            Console.Read();

        }

    }

}