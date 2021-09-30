using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqPost3
{
    
    class MainClass
    {
        public static void Main(string[] args)
        {
           
           var db = new FakeDatabase();
            //var query1 =
            //     from lecture in db.Lectures
            //     group lecture by lecture.TeacherId into grouped
            //     join teacher in db.Teachers on grouped.Key equals teacher.Id
            //     where teacher.LastName == "Williams"
            //     select new
            //     {
            //         TeacherId = grouped.Key,
            //         Name = teacher.GivenName
            //     };



            //Console.WriteLine("Query syntax");
            //foreach (var obj in query1)
            //{
            //    Console.WriteLine(obj.TeacherId + " " + obj.Name);
            //}

           //var inc = from tc in db.Teachers.Include(blog => blog.Posts)
        //.ToList();
            //uno Lectures y Teachers por el Id , creo un tipo anonimo nuevo
            var mijoin =
                from tc in db.Lectures
                join lc in db.Teachers
                on tc.TeacherId equals lc.Id//equals Id
                select new//tipo anonimo
                {
                    
                    tece = tc.Name,
                    lecc = lc.GivenName
                };
            foreach (var c in mijoin)//Recorro con for como siempre
            {
                Console.WriteLine(c.lecc + " " + c.tece);
            }

            Console.Read();


            //GroupJoin
            var q5 =
                from l in db.Lectures
                group l by l.TeacherId into grouped//primero hago el grupo de Lecturas por profesor
                join t in db.Teachers on grouped.Key equals t.Id //Luego join entre el grupo y Profesores
                select new
                {
                    TeacherName = t.GivenName,
                    TeacherId = t.Id,
                    LectureCount = grouped.Count()
                };
            

            var q5alt = db.Lectures
                .GroupBy(l => l.TeacherId)
                .Join(db.Teachers, grouped => grouped.Key, t => t.Id,
                (grouped, t) => new
                {
                    TeacherName = t.GivenName,
                    TeacherId = t.Id,
                    LectureCount = grouped.Count()
                });

            Console.WriteLine("Clases por profesor:");
            foreach (var item in q5.OrderBy(t => t.LectureCount).Take(5))
            {
                Console.WriteLine(item.TeacherName + "\t" + item.LectureCount);
            }
            Console.WriteLine();
            Console.Read();

            //var query1incl = from lecture in db.Teachers.Include





              void InnerJoinExample()
            {
                

                var autores = new List<Autor>()
        {
            new Autor {
                        ID_Autor        = 1,
                        Nombre          = "Federico García Lorca",
                        FechaNacimento  = new DateTime(1898, 6, 5),
                        LugarNacimiento = "España"
                        },
            new Autor {
                        ID_Autor        = 2,
                        Nombre          = "William Blake",
                        FechaNacimento  = new DateTime(1757,12, 8),
                        LugarNacimiento = "Inglaterra"
                        },
            new Autor {
                        ID_Autor        = 3,
                        Nombre          = "Antonio Machado Ruiz",
                        FechaNacimento  = new DateTime(1875, 7, 26),
                        LugarNacimiento = "España"
                        }
        };


                var publicaciones = new List<Publicacion>()
        {
            new Publicacion
            {
                ID_Publi         = 1,
                Titulo           = "Songs of Innocence",
                Fecha            = new DateTime(1789, 1, 1),
                ID_Autor         = 2,
                LugarPublicacion = "Inglaterra"
            },
            new Publicacion
            {
                ID_Publi         = 2,
                Titulo           = "Soledades: poesías",
                Fecha            = new DateTime(1903, 1, 1),
                ID_Autor         = 3,
                LugarPublicacion = "España"
            },
            new Publicacion
            {
                ID_Publi         = 3,
                Titulo           = "El Romancero Gitano",
                Fecha            = new DateTime(1918, 1, 1),
                ID_Autor         = 1,
                LugarPublicacion = "España"
            },
            new Publicacion
            {
                ID_Publi         = 4,
                Titulo           = "Poeta en Nueva York",
                Fecha            = new DateTime(1930, 1, 1),
                ID_Autor         = 1,
                LugarPublicacion = "España"
            },
            new Publicacion
            {
                ID_Publi         = 5,
                Titulo           = "Páginas escogidas",
                Fecha            = new DateTime(1917, 1, 1),
                ID_Autor         = 3,
                LugarPublicacion = "España"
            }
        };


                var joinConsultaut = from a in autores
                                   join p in publicaciones
                                   on a.ID_Autor equals p.ID_Autor
                                   select new
                                   {
                                       Autor = a.Nombre,
                                       Titulo = p.Titulo,
                                       FechaPublicacion = p.Fecha
                                   };
                Console.WriteLine("Expresión de Consulta:");

                foreach (var j in joinConsultaut)
                {
                    Console.WriteLine("{0,-21} - {1,-19} - {2:d}", j.Autor, j.Titulo, j.FechaPublicacion);
                }

                Console.Read();

                var joinLambdaut = autores.Join                       // Colección 1
                    (
                        publicaciones,                              // Colección 2
                        a => a.ID_Autor,                            // Clave Colec 1
                        p => p.ID_Autor,                            // Clave Colec 2
                        (a, p) => new {                             // Colección de resultado
                    Autor = a.Nombre,
                            Titulo = p.Titulo,
                            FechaPublicacion = p.Fecha
                        }
                    );

               
                Console.WriteLine("Expresión Lambda:");

                foreach (var j in joinLambdaut)
                {
                    Console.WriteLine("{0,-21} - {1,-19} - {2:d}", j.Autor, j.Titulo, j.FechaPublicacion);
                }

                Console.Read();

                               

                

                var joinWhere = from a in autores
                                from p in publicaciones
                                where a.ID_Autor == p.ID_Autor && a.LugarNacimiento == p.LugarPublicacion
                                select new
                                {
                                    Autor = a.Nombre,
                                    Titulo = p.Titulo,
                                    FechaPublicacion = p.Fecha
                                };

                //groupjoin
                var groupJoinConsulta = from a in autores
                                        join p in publicaciones
                                        on a.ID_Autor equals p.ID_Autor into agrupados
                                        select new
                                        {
                                            Autor = a,
                                            Publicaciones = agrupados
                                        };
                var groupJoinLambda = autores.GroupJoin                         // Colección 1
                        (
                            publicaciones,                                          // Colección 2
                            a => a.ID_Autor,                                        // Clave Colec 1
                            p => p.ID_Autor,                                        // Clave Colec 2
                            (padre, hijos) => new {                                 // Colección de resultado
                Autor = padre,
                                Publicaciones = hijos
                            }
                        );


                Console.WriteLine("Expresión de Consulta:");

                foreach (var grupo in groupJoinConsulta)
                {
                    Console.WriteLine("***  {0}  ***", grupo.Autor);

                    foreach (var publicacion in grupo.Publicaciones)
                    {
                        Console.WriteLine("    {0,-21} - {1,-19} - {2:d}", publicacion.Titulo, publicacion.LugarPublicacion, publicacion.Fecha);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Expresión Lambda:");

                foreach (var grupo in groupJoinLambda)
                {
                    Console.WriteLine("***  {0}  ***", grupo.Autor);

                    foreach (var publicacion in grupo.Publicaciones)
                    {
                        Console.WriteLine("    {0,-21} - {1,-19} - {2:d}", publicacion.Titulo, publicacion.LugarPublicacion, publicacion.Fecha);
                    }
                }
                Console.Read();



                Console.Read();


            }




        }



        }
        

        
    public class Autor
    {
        public int ID_Autor { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimento { get; set; }
        public string LugarNacimiento { get; set; }
    }
    public class Publicacion
    {
        public int ID_Publi { get; set; }
        public string Titulo { get; set; }
        public int ID_Autor { get; set; }
        public DateTime Fecha { get; set; }
        public string LugarPublicacion { get; set; }
    }

    


}



