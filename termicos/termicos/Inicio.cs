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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            bregistro.Enabled = false;

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            controlarBotones();


        }



        private void controlarBotones()
        {
            if (name.Text.Trim() != string.Empty && name.Text.All(Char.IsLetter))
            {
                bregistro.Enabled = true;
                errorProvider1.SetError(name, "");

            }
            else
            {
                if (!(name.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(name, "solo letras chaval");

                 }
                else
                {
                    errorProvider1.SetError(name, "pon algo paleto");
                }

                bregistro.Enabled = false;
                name.Focus();


            }


        }

        private void bregistro_Click(object sender, EventArgs e)
        {
            using (calculos ventana = new calculos(name.Text))
                ventana.ShowDialog();
        }
    }

}



