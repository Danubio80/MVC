using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace PRACITCAS1
{
    class Program
    {

        
        static void Main(string[] args)
        {

            XmlTextReader leerxml = new XmlTextReader("C:\\Users\\danid\\source\\ºrepos\\Ejercicios\\Ejercicios\\Customers.xml");
            var lectura =leerxml.HasAttributes.Equals("custumers");

            Console.WriteLine( lectura);
        }

    }
}
