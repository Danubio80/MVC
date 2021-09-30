using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenador
{
    public delegate void Delegadomoto(int sender);
    class Moto
    {
        public event Delegadomoto eventovelocidad;

        public Moto(int velocidad)
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

            set {
                if (value>220)
                {
                    if (eventovelocidad != null) 

                    {
                        eventovelocidad(value);
                        this.velocidad = 120;
                    }
                }
                
                
                
                velocidad = value; }
        }

        public void acelerar()
        {
            this.velocidad += 10;
        }

        public void acelerar(int velocidad)
        {
            this.Pvelocidad += velocidad;
        }

        public void   frenar()
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
