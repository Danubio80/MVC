using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    class Persona
    {
        private string nombre;

        public string P_nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int edad;

        public int P_edad
        {
            get { return edad; }
            set {

                if (value>=18)
                {
                    Console.WriteLine("Es mayor");
                }
                else
                {
                    Console.WriteLine("Es menor");
                }
                
            }

        }

    }
}
