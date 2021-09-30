using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termicos
{
    public partial class calculos : Form
    {
        string nameCLiente;

        string[] series = { "corredera", "practicable", "balconera" };
        




        public calculos(string name)
        {
            InitializeComponent();

            nameCLiente = name;

            comboBox1.Items.Add(nameCLiente);

        }

        private void bvolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
