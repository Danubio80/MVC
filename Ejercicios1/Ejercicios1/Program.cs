using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {

        //ejercicio1

            //Console.WriteLine("Dime tu primer numero");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Dime tu segundo numero");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //double sum = num1 + num2;
            //double mult = num1 * num2;
            //double rest = num1 - num2;
            //double div = num1 / num2;
            //if (num1>num2)
            //{

            //    Console.WriteLine("La suma de {0} y {1} tiene como resultado {2}",num1,num2,sum);
            //    Console.WriteLine("La diferencia de {0} y {1} tiene como resultado {2}",num1,num2,rest);
            //}
            //else
            //{
            //    Console.WriteLine("El producto de {0} y {1} tiene como resultado {2}",num1,num2,mult);
            //    Console.WriteLine("La divison de {0} y {1} tiene como resultado {2}", num1, num2,div);
            //}

        //ejercicio2

            //Console.WriteLine("Escribe un numero del 1 al 99");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num>9)
            //{
            //    Console.WriteLine("El numero tiene dos cifras");

            //}
            //else
            //{
            //    Console.WriteLine("El numero tiene una cifra");
            //}

        //ejercicio3

            //Console.WriteLine("Escribe un numero del 1 al 5");
            //int num =Convert.ToInt32(Console.ReadLine());
            //switch (num)

            //{
            //    case 1:
            //        Console.WriteLine("UNO");
            //        break;
            //    case 2:
            //        Console.WriteLine("DOS");
            //        break;
            //    case 3:
            //        Console.WriteLine("TRES");
            //        break;
            //    case 4:
            //        Console.WriteLine("CUATRO");
            //        break;
            //    case 5:
            //        Console.WriteLine("CINCO");
            //        break;

            //    default:
            //        Console.WriteLine("Ingresa un número del 1 al 5 ");
            //        break;
            //}

        //ejercicio 4

            //Console.WriteLine("Introduce un carácter");
            //char caracter = Convert.ToChar(Console.ReadLine());
            //switch (caracter)
            //{
            //    case '.' :
            //    case ',' :
            //    case ';' :
            //    case ':' :
            //        Console.WriteLine("Has escrito un signo de puntuacion");
            //        break;
            //    case '0':
            //    case '1':
            //    case '2':
            //    case '3':
            //    case '4':
            //    case '5':
            //    case '6':
            //    case '7':
            //    case '8':
            //    case '9':
            //        Console.WriteLine("Has escrito un número");
            //        break;

            //    default:
            //        Console.WriteLine("Has escrito algún otro carácter");
            //        break;
            //}

        //ejercicio 5

            //Console.WriteLine("Escribe un numero");
            //int num =Convert.ToInt32(Console.ReadLine());
            //string result= (num > 0) ? "El numero es positivo" :"El numero es negativo";
            //Console.WriteLine(result);

        //ejercicio 6

            //Console.WriteLine("Dime tu primer numero");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dime tu segundo numero");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //String result =(num1 % num2 == 0) ? "Son multiplos" : "No son multiplos";
            //Console.WriteLine(result);

            //if (num1 % num2 == 0)
            //{
            //    Console.WriteLine("{0} es multiplo de {1}",num1,num2);
            //}
            //else
            //{
            //    Console.WriteLine("{0} no es multiplo de {1}", num1, num2);
            //}

        //ejercicio 7

            //doy por hecho que los numeros tienen que ser diferentes
            //Console.WriteLine("Dime tu primer numero");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dime tu segundo numero");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dime tu tercer numero");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //if (num1>num2&&num1>num3)
            //{
            //    Console.WriteLine("El {0} es mayor que {1} y {2}",num1,num2,num3);
            //}
            //else if (num2>num1&&num2>num3)
            //    Console.WriteLine("El {0} es mayor que {1} y {2}", num2, num1, num3);
            //else
            //{
            //    Console.WriteLine("El {0} es mayor que {1} y {2}", num3, num1, num2);
            //}

        //ejercicio 8

            //Console.WriteLine("Dime tu numero:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num>0)
            //{
            //    Console.WriteLine("El {0} es mayor que 0", num);
            //}
            //else if (num < 0)
            //{
            //    Console.WriteLine("El {0} es menor que 0", num);
            //}
            //else 
            //{
            //    Console.WriteLine("El {0} es igual que 0", num);
            //}

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("El {0} es par", num);
            //}
            //else
            //{
            //    Console.WriteLine("El {0} es impar", num);
            //}
            //if (num % 5 == 0)
            //{
            //    Console.WriteLine("El {0} es multiplo de 5", num);
            //}
            //else
            //{
            //    Console.WriteLine("El {0} no multiplo de 5", num);
            //}
            //if (num % 10 == 0)
            //{
            //    Console.WriteLine("El {0} es multiplo de 10", num);
            //}
            //else
            //{
            //    Console.WriteLine("El {0} no es multiplo de 10", num);
            //}

        //ejercicio 9

            //Console.WriteLine("Horas trabajadas esta semana");
            //int horasTrab = Convert.ToInt32(Console.ReadLine());
            //if (horasTrab<=40)
            //{
            //    int salario = 16 * horasTrab;
            //    Console.WriteLine("tu salario es {0}", salario);
            //}
            //else if (horasTrab>40)
            //{
            //    int salarioExtra = (40 * 16) + ((horasTrab-40) * 20);
            //    Console.WriteLine("tu salario es {0}", salarioExtra);
            //}

        //ejercicio 10

            //var dadoN1 = new Random().Next(1, 7);
            //var dadoN2 = new Random().Next(1, 7);
            //var dadoN3 = new Random().Next(1, 7);
            //Console.WriteLine("{0} {1} {2}", dadoN1, dadoN2, dadoN3);

            //if (dadoN1 == 6 && dadoN2 == 6 && dadoN3 == 6)
            //{
            //    Console.WriteLine("EXCELENTE");
            //}
            //else if (dadoN1 == 6 && dadoN3 == 6)
            //{
            //    Console.WriteLine("MUY BIEN");
            //}
            //else if (dadoN1 == 6 && dadoN2 == 6)
            //{
            //    Console.WriteLine("MUY BIEN");
            //}
            //else if (dadoN2 == 6 && dadoN3 == 6)
            //{
            //    Console.WriteLine("MUY BIEN");
            //}
            //if (dadoN1 == 6 || dadoN2 == 6 || dadoN3 ==6)
            //{
            //    Console.WriteLine("REGULAR");
            //}
            //else
            //{
            //    Console.WriteLine("PESIMO");
            //}

        //ejercicio 11

            //var temp = new Random().Next(-10, 46);
            //Console.WriteLine(temp + " Grados");
            //if (temp >= -10 && temp <= 10)
            //{
            //    Console.WriteLine("Mucho frio");
            //}
            //else if (temp > 10 && temp <= 15)
            //{
            //    Console.WriteLine("Poco Frio");
            //}
            //else if (temp > 15 && temp <= 25)
            //{
            //    Console.WriteLine("Temperatura Normal");
            //}
            //else if (temp > 25 && temp <= 30)
            //{
            //    Console.WriteLine("Poco calor");
            //}
            //else 
            //{
            //    Console.WriteLine("Mucho calor");
            //}


        }
    }
}
