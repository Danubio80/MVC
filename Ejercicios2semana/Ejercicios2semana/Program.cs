using System;

namespace Ejercicios2semana
{

    enum Razas { negros, blancos, grises }
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Crea un pais");
            string Raza ="";
            string opRaza;

            Console.Write("Dime pais ");
            string Nombre = Console.ReadLine();
            Console.Write("Dime capital ");
            string Capital = Console.ReadLine();
            Console.Write("Numero de habitantes ");
            int NumHabitantes = Convert.ToInt32(Console.ReadLine());
            Console.Write("razas disponibles:\n ");
            Console.Write("");
            var valores = Enum.GetValues(typeof(Razas));
            foreach (var item in valores)
            {
                Console.WriteLine(item);
            }
            Console.Write("");
            Console.WriteLine("elige raza ");

            do
            {
                opRaza = Console.ReadLine();
                if ((Enum.IsDefined(typeof(Razas), opRaza) == true))
                {
                    Raza = opRaza;
                }
                else { Console.WriteLine("elige raza de la lista please"); }


            } while (Enum.IsDefined(typeof(Razas), opRaza) != true);



            Pais p1 = new Pais(Nombre, Capital, NumHabitantes, Raza);

            Console.WriteLine("El pais creado es :" + p1.Nombre + " su capital es " + p1.Capital + " sus habitantes son de raza " + p1.Raza);


            Console.WriteLine("Añadir ciudades a {0}  ", p1.Nombre);
            Console.WriteLine("Cuantas ciudades quieres añadir");
            int nciudades = Convert.ToInt32(Console.ReadLine());
            string[] ciudades = new string[nciudades];
            for (int i = 0; i < nciudades; i++)
            {
                Console.WriteLine("dime ciudad");
                ciudades[i] = Console.ReadLine();

            }

            Console.WriteLine("El pais creado es :" + p1.Nombre + " su capital es " + p1.Capital + " sus habitantes son de raza " + p1.Raza);
            Console.WriteLine("tiene estas ciudades:");
            foreach (var item in ciudades)
            {
                Console.WriteLine(item);
            }



        }



    }
}
public class Pais
{
    private string nombre;
    private string capital;
    private int numHabitantes;
    private string raza;
    private Array ciudades;
    public string Nombre { get => nombre; set => nombre = value; }
    public string Capital { get => capital; set => capital = value; }
    public int NumHabitantes { get => numHabitantes; set => numHabitantes = value; }
    public string Raza { get => raza; set => raza = value; }
    public Array Ciudades { get => ciudades; set => ciudades = value; }

    public Pais(string nombre, string capital, int numHabitantes, string raza)
    {
        this.Nombre = nombre;
        this.Capital = capital;
        this.NumHabitantes = numHabitantes;
        this.Raza = raza;
    }
}


