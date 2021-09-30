using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMio
{
    public class Database
    {


        private Libros[] libro = new Libros[]{

            new Libros {id= 1, autor="pere",nombre="ensayo" },
            new Libros {id= 2, autor="perez",nombre="ensayodd" },

            };
        public  Libros [] libritos
        {
            get { return libro; }
        }





        public Profesores[] Profesores
        {
            get { return profes; }
        }

        // creo un array de profesoseres de manera estatica para no necesitar un constructor de profesores




        private static Profesores[] profes = new Profesores[]
        {
            new Profesores { id = 1,edad=23,nombre="epe" },
            new Profesores { id = 2,edad=32,nombre="eped" },
            new Profesores { id = 3,edad=66,nombre="epedss" },
        };

    }
}
