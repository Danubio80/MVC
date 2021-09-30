using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoLucas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
         int edad  =Convert.ToInt32(textEdad.Text);

            if (edad > 18)
            {
                label2.Text= "Puedes salir a correr";
            }
            else
            {
                label2.Text = "Eres un enano";
            }


        }

        
    }
}
