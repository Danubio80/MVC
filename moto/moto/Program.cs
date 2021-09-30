using System;

namespace moto
{
    class Program
    {
        static void Main(string[] args)
        {
            moto numero1 = new moto(50);
            numero1.acelerar();
            numero1.acelerar(10);
            numero1.frenar();

            moto numero2 = new moto(50);
            numero2.acelerar();
            numero2.acelerar(10);
            numero2.frenar();
            moto.numeroMotos();
            if (numero1.Pvelocidad > numero2.Pvelocidad)
            {
                Console.WriteLine("Va mas deprisa la moto1");
            }
            else
            {
                Console.WriteLine("Va mas deprisa la moto2");
            }

            









        }


    }
}
