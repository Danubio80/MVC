using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculodigitos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador=0;
            int indice=int.Parse(cuadro1.Text);
            while (indice>0)
            {
                indice = indice / 10;
                contador++;
            }
            MessageBox.Show("numero de digitos " + contador);
        }

        private void ACEPTAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Continua con ejecucuion", "Mensaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        }

        private void BORRA_Click(object sender, EventArgs e)
        {
            cuadro1.Clear();
            cuadro1.Focus();
        }
    }
}
