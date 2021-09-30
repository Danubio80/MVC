using System;

namespace poo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta nueva = new Cuenta("pepe",25);

            try
            {
                Console.WriteLine("Introduce cantidad a ingresar");
                double ingreso = Convert.ToDouble(Console.ReadLine());
                nueva.ingresar(ingreso);
            }
            catch (Exception)// habria que crear una clase que herede de exception??
            {
                Console.WriteLine("cantidad introducida negativa");

            }
            

            Console.WriteLine("Introduce cantidad a retirar");
            double gasto = Convert.ToDouble(Console.ReadLine());
            nueva.retirar(gasto);
            
            nueva.muestra();//como se generaba de manera automatica el metodo ToString

            
        }
    }
}
