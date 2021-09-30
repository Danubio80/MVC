using System;

namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Dime tu nombre");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Dime tu edad");
            //int edad = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("tu nombre es {0} {1}",nombre,edad );

            //Console.WriteLine("Dame tu numero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //if (numero>10)
            //{
            //    Console.WriteLine("El numero {0} es mayor que 10",numero);
            //}
            //else
            //{ 
            //    Console.WriteLine("El numero {0} es menor que 10",numero);
            //}

            //Console.WriteLine("Dame tu numero 1");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dame tu numero 2");
            //int numero2 = Convert.ToInt32(Console.ReadLine());

            //if (numero2  % numero1 == 0)
            //{
            //    Console.WriteLine("{0} ", numero);
            //}

            //else
            //{
            //    Console.WriteLine(" {0} ", numero);

            //}


            //Console.WriteLine("Dame tu numero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //if (numero == 10)

            //{

            //    Console.WriteLine(" {0} es = 10 ", numero);

            //}
            //else

            //Console.WriteLine(" {0} es = 0 ", numero);
            //if (numero > 10)
            //{

            //    Console.WriteLine(" {0} es > 10 ", numero);
            //}
            //if (numero < 10)
            //{

            //    Console.WriteLine(" {0} es < 10 ", numero);

            //}



            //Console.WriteLine("Dame tu numero que te lo convierto al romano");
            //int num = Convert.ToInt32(Console.ReadLine());
            //switch (num)
            //{  case 1:
            //    Console.WriteLine("el numero es I");
            //        break;
            //    case 2:
            //    Console.WriteLine("el numero es II");

            //    break;

            //    default: Console.WriteLine("el numero no existe");
            //    break;


            //}

            Console.WriteLine("Dame tu nota");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("INSUFICIENTE");
                    break;
                case 5:
                    Console.WriteLine("SUFICIENTE");

                    break;

                default:
                    Console.WriteLine("el numero no existe");
                    break;



            }












        }
    }
}
