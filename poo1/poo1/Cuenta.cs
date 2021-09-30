using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo1
{
    class Cuenta
    {

        public Cuenta(string titular)
        {
            this.titular = titular;
        }
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }


        private string titular;

        public string Ptitular
        {
            get { return titular; }
            set { titular = value; }
        }
                     

        private double cantidad;
        public double Pcantidad
        {
            get { return cantidad; }
           
        }

        public void retirar(double cantidad)
        {
            if (this.cantidad-cantidad<0)
            {
                this.cantidad = 0;
            }
            else 
            {
               this.cantidad-= cantidad;
            }

          
        }

        public void muestra()
        {
            Console.WriteLine("la cantidad de "+this.cantidad + " euros esta en la cuenta de "+ this.titular);
        }


        public void ingresar(double cantidad)
        {
            this.cantidad = cantidad;
        }





    }
}
