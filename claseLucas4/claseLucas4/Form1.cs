using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claseLucas4
{
    public partial class Form1 : Form
    {
        List<string> lista = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {

           
            {
                string nombre = textCliente.Text;
                textCliente.Text = "";

                

                lista.Add(nombre);

                traerListado();
            }


            



             List<string> traerListado()
            {
                List < string > lista= new List<string>();
                lista.Add("pepe");
                lista.Add("juan");
                lista.Add("fran");
                return lista;

            }


        }

        private void buttonMostar_Click(object sender, EventArgs e)
        {
            foreach (var items in lista)
            {
                MessageBox.Show(items);
            }

        }
    }
}
