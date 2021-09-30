using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoCompras
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();

            cliente.Nombre = textNombre.Text;
            cliente.Apellido = textApellido.Text;
            cliente.Telefono = textTelefono.Text;
            cliente.Tarjeta = textTarjeta.Text;

                   
            
            ListaClientes.Items.Add(cliente);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int indice= ListaClientes.SelectedIndex;

            ListaClientes.Items.RemoveAt(indice);
            
        }
    }
}
