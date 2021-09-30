using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moto
{
    class moto
    {
        

        public moto(int velocidad)
        {
            this.velocidad = velocidad;
            contadormotos++;

        }



        private int cilindros;

        public int Pcilindros
        {
            get { return cilindros; }
            set { cilindros = value; }
        }

        private int velocidad;
        public int Pvelocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }

        public void acelerar()
        {
            this.velocidad += 10;
        }

        public void acelerar(int velocidad)
        {
            this.velocidad += velocidad;
        }

        public void  virtual frenar()
        {
            this.velocidad -= 10;
        }
        

        public static int contadormotos;

        public static void numeroMotos()
        {
            Console.WriteLine("se ha creado " + contadormotos);
        }
        





    }






}
