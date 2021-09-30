using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    class Contador
    {
        public Contador()
        {
        }

        public Contador(int contador)
        {
            if(contador>0){

                this.contador = contador;

            }else

            this.contador = 0;
        }



        private int contador;

        public int Pcontador
        {
            get { return contador; }
            set {
                if (value<0)
                {
                    this.contador = 0;
                }
                else
                {
                    contador = value;
                }
                }
        }



        public void incremententar()
        {
            this.contador++;
        }
        public void decrementar()
        {
           this.Pcontador--;
        }


    }
}
