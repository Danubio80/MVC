using System;

namespace EjerciciosBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 0; ;
            //while (num<=100)
            //{
            //    Console.WriteLine(num);
            //    Console.Write("");
            //    num++;

            //}
            //int num = 0;
            //do
            //{

            //    Console.WriteLine(num);
            //    Console.Write("");
            //    num++;
            //} while (num <= 100);

            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);

            //}
            //Listar números de 100 al 0 de 23 en 23
            //for (int i = 100; i >=0; i-=23)
            //{
            //    Console.WriteLine(i);
            //}

            //3. Realiza un programa que nos diga cuantos dígitos tiene un número introducido por teclado.

            //Console.WriteLine("introduce numero:");

            //int numero=int.Parse(Console.ReadLine());

            //int contador = 0;
            //while (numero>0)
            //{

            //    numero = numero / 10;
            //    contador++;
            //}
            //Console.WriteLine(contador);

            /*4.Desarrollar un programa que permita la carga de 10 valores por teclado y
            nos muestre posteriormente la suma de los valores ingresados y su
            promedio.*/
            //double suma = 0; ;

            ////for (int i = 0; i <= 10; i++)
            ////{
            ////    Console.WriteLine("Dame numero " + i);
            ////    double numero =double.Parse(Console.ReadLine());
            ////    suma += numero;
            ////}
            ////Console.WriteLine("");
            ////Console.WriteLine("La suma da "+suma);
            ////Console.WriteLine("El promedio da "+suma/10);

            /*5.Escribir un programa que solicite ingresar 10 notas de alumnos y nos
                      informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.*/

            //int notaAlta = 0;
            //int notaMenos7 = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("Dame nota Alumno " + (i+1));
            //    double nota = double.Parse(Console.ReadLine());
            //    if (nota >= 7)
            //    {

            //        notaAlta++;
            //    }
            //    else
            //    {
            //       notaMenos7++;
            //    }

            //}

            //Console.WriteLine("El numero de notas mayores o iguales de 7, es {0}", notaAlta);
            //Console.WriteLine("El numero de notas mayores o iguales de 7, es {0}", notaMenos7);



            /*En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
            $500, realizar un programa que lea los sueldos que cobra cada empleado e
            informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
            de $300.Además el programa deberá informar el importe que gasta la
            empresa en sueldos al personal. */


            //int csueldo1 = 0;
            //int csueldo2 = 0;
            //double sueldo,sueldoTotal;
            //double sueldo1 = 0;
            //double sueldo2 = 0;
            //double sueldo3 = 0;

            //do
            //{
            //    Console.WriteLine("Introduce sueldo empleado,pulsa 0 para salir");
            //    sueldo = double.Parse(Console.ReadLine());
            //    if (sueldo>=100 && sueldo <=300)
            //    {
            //        sueldo1 +=sueldo;
            //        csueldo1++;

            //    }
            //    else if (sueldo>300)
            //    {
            //        sueldo2 += sueldo;
            //        csueldo2++;
            //    }
            //    else
            //    {
            //        sueldo3 += sueldo;
            //    }


            //} while (sueldo!=0);
            //sueldoTotal = (sueldo1 + sueldo2 + sueldo3);
            //Console.WriteLine("El numero de empleados con sueldo entre 100 y 300, es "+csueldo1);
            //    Console.WriteLine("El numero de empleados con sueldo mayor de 300, es "+csueldo2);
            //    Console.WriteLine("El gasto total en sueldos es "+sueldoTotal);


            /*Crea una aplicación que dibuje una escalera de asteriscos.Nosotros le pasamos
           la altura de la escalera por teclado. Este es un ejemplo si insertaras un 5 de
           altura:*/

            //Console.WriteLine("Dame altura de la piramide");
            //int altura= int.Parse(Console.ReadLine());
            //string cadena = "*";
            //do
            //{
                
            //    Console.WriteLine(cadena);
            //    cadena=cadena+"*";
            //    altura--;
                
            //} while (altura>0);
            

        


        }
    }
}
