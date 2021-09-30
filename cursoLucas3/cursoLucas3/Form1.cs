using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursoLucas3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculo_Click(object sender, EventArgs e)
        {
            int peso = Convert.ToInt32(textPeso.Text);
            double altura = Convert.ToDouble(textAltura.Text);

            double imc = peso / (altura * altura);
            MessageBox.Show("El indice de masa corporal es:" + imc);
        }
    }
}
