using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosColecciones
{
    class Mensaje
    {
        public Mensaje(int id, string texto)
        {
            this.id = id;
            this.texto = texto;
        }


        private int id;

        public int P_ide
        {
            get { return id; }
            set { id = value; }
        }

        private string texto;

        public string P_texto
        {
            get { return texto; }
            set { texto = value; }
        }


        public override string ToString()
        {
            return this.P_ide + this.P_texto;
        }


    }
}
