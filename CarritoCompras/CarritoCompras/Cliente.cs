using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Cliente
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private string tarjeta;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Tarjeta { get => tarjeta; set => tarjeta = value; }



        public string NombreCompleto()
        {
            return Nombre + " " + Apellido;
        }


        public override string ToString()
        {
            return NombreCompleto();
        }
    }
}