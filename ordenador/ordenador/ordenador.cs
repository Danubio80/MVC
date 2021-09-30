using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenador
{
    class Ordenador
    {
        public Ordenador(int memoria,string soperativo)
        {
            this.memoria = memoria;
            this.soperativo = soperativo;
        }

        public Ordenador(string soperativo)
        {
            this.soperativo = soperativo;
        }

        private string marca;

        public string P_marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private int memoria;

        public int Pmemoria
        {
            get { return disco; }
            set { memoria = value; }
        }



        private int disco;

       

        public int P_disco
        {
            get { return disco; }
            set { 
                if (disco > 10000)
                {
                    Console.WriteLine("error");
                    throw new Exception();
                }
                disco = value; }
        }

        public void arrancar()
        {
            Console.WriteLine("arrancanco");
        }

        public void apagar()
        {
            Console.WriteLine("apagar");

        }

        public int memoriagas()
        {
            return this.memoria - 512;
        }

        public int memoriagas(int memoria)
        {
            return this.memoria - memoria;
        }

        private string soperativo;

        public string Poperativo
        {
            get { return soperativo; }
            
        }


        
    }


    








    class Portatil : Ordenador
    {
        public Portatil(string soperativo,int pulgadas) : base(soperativo)
        {
            this.pulgadas = pulgadas;
        }

        private int pulgadas;

        public int Ppulgadas
        {
            get { return pulgadas; }
            set { pulgadas = value; }
        }

        public void suspender()
        {

        }

        


    }





}
