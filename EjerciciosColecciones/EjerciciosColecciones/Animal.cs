using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosColecciones
{
    class Animal
    {
        private string nombre;
        private double peso;
        private int patas;

        public Animal(string nombre, double peso, int patas)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.patas = patas;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Peso { get => peso; set => peso = value; }
        public int Patas { get => patas; set => patas = value; }


         public string DameNombre { get; set; }
        

       



    }




   


}
