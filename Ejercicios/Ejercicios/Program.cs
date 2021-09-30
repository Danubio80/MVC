using System;
using System.Collections;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            //XDocument cargadocumento = XDocument.Load
            //Console.WriteLine(cargadocumento);


            //Console.WriteLine(cargadocumento.Elements()) ;


            XElement xmlTree = XElement.Parse("Customers");
            Console.WriteLine(xmlTree.Elements("orders"));
        }








    }
}
