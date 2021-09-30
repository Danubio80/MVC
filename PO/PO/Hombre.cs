using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    public delegate void Deleghom(int ed);

    class Hombre
    {
        public event Deleghom eventoalturahombre;




        private int altura;

        public int P_altura
        {
            get { return altura; }
            set { altura = value; }
        }




        private int edad;

        public Hombre(int edad)
        {
            this.edad = edad;
        }

        public int P_edad
        {
            get { return edad; }
            
            }
        }






        public void muestraHombre()
        {
            Console.WriteLine("dsfdsfds"+);


        }


        private int peso;

        public int P_peso
        {

            set { peso = value;
                    }
        }

        private string nombre;

        public string P_nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public void cumpliraños()
        {
            this.edad++;
        }

        public void engordad()
        {
        

            this.peso += 5;
        
        }

        public void engordar(int numkilos)
    {
        this.P_peso -= numkilos;
    }
        

   




    }
}
