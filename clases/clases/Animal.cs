using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    
        class Animal
        {
            private string _Especie;
            private string _Nombre;
            private double _Peso;
            private int _Patas;

            public Animal(string especie, string nombre, double peso, int patas)
            {
                Especie = especie;
                Nombre = nombre;
                Peso = peso;
                Patas = patas;
            }

            public string Especie { get => _Especie; set => _Especie = value; }
            public string Nombre { get => _Nombre; set => _Nombre = value; }
            public double Peso { get => _Peso; set => _Peso = value; }
            public int Patas { get => _Patas; set => _Patas = value; }

            public override string ToString()
            {
                return "Animal: Especie = " + this.Especie + "; Nombre = "
                    + this.Nombre + "; Peso = " + this.Peso + "; Num_Patas = " + this.Patas;
            }

        

    }
}
