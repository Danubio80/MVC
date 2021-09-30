using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPost2
{
    public enum TipoCarburante
    {
        Gasolina,
        Diesel
    }
    class Automovil
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public TipoCarburante Carburante { get; set; }
        public ConsoleColor Color { get; set; }
        public int potencia { get; set; }
    }
}
