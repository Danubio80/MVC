using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moto
{
    class scooter : moto
    {
        
        private int Nasientos;

        public scooter(int velocidad) : base(velocidad)
        {
        }

        public int PNasientos
        {
            get { return Nasientos; }
            set { Nasientos = value; }
        }

        public void arrancar()
        {
            Console.WriteLine("He arrancado");
        }

        public void acelerar(double velocidad)
        {
            this.Pvelocidad = this.Pvelocidad + (int)velocidad;
        }

        public new void frenar()
        {
            Console.WriteLine("has freando");
        }
    }
}
