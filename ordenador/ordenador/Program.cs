using System;

namespace ordenador
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ordenador ordenador = new Ordenador("windows");
            //Portatil Portatil = new Portatil("windows",14);


            Moto moto = new Moto(4);
            moto.eventovelocidad += Moto_eventovelocidad;
            Moto moto2 = new Moto(5);
            moto2.eventovelocidad += Moto2_eventovelocidad;
            moto2.acelerar(300);


        }

        private static void Moto2_eventovelocidad(int sender)
        {
            Console.WriteLine("VELOCIDAD MUY ALTA "+sender);
        }

        private static void Moto_eventovelocidad(int sender)
        {
            throw new NotImplementedException();
        }
    }

}
