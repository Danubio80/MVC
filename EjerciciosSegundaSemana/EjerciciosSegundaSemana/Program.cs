using System;

namespace EjerciciosSegundaSemana
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] ntmañana = new string[4];
            double[] stmañana = new double[4];
            double totalSmañana = 0;
            string[] ntarde = new string[4];
            double[] starde = new double[4];
            double totalStarde = 0;
            Console.WriteLine("Seleccione turno.\n Pulse 'm' para mañana y 't' para tarde");
            char turno = Convert.ToChar(Console.ReadLine());
            switch (turno)
            {
                case 't':

                    for (int i = 0; i < ntarde.Length; i++)
                    {
                        Console.WriteLine("Nombre: ");
                        ntarde[i] = Console.ReadLine();
                        Console.WriteLine("salario: ");
                        starde[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    for (int i = 0; i < stmañana.Length; i++)
                    {
                        totalStarde += starde[i];
                    }
                    Console.WriteLine("Salario total del personal de tardes: " + totalStarde);
                    for (int i = 0; i < starde.Length; i++)
                    {
                        Console.WriteLine(ntarde[i] + " cobra " + starde[i]);
                    }
                    break;

                case 'm':

                    for (int i = 0; i < ntmañana.Length; i++)
                    {
                        Console.WriteLine("Nombre: ");
                        ntmañana[i] = Console.ReadLine();
                        Console.WriteLine("salario: ");
                        stmañana[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    for (int i = 0; i < stmañana.Length; i++)
                    {
                        totalSmañana += stmañana[i];
                    }
                    Console.WriteLine("Salario total del personal de mañanas: " + totalSmañana);

                    for (int i = 0; i < stmañana.Length; i++)
                    {
                        Console.WriteLine(ntmañana[i] + " cobra " + stmañana[i]);
                    }

                    break;
            }


            /* Crear tupla con 4 item.En este ejemplo, creamos una tupla de
 cuatro elementos, dos de ellos matrices: la primera de string, la
 segunda de int.Inicializamos los arrays en el main y luego pasamos
 nuestra variable Tuple a otro método, donde recorremos los
 elementos del array de cadenas*/

            string[,] nombres= new string[2, 2];
            int[,] numeros = new int[2, 2];
            Tuple<nombres, numeros, DateTime.Now>[] empleados =
            {

            };
           
            





        }
    }
}
