using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Cliente
{
    public partial class Insertar_Cliente : Form
    {
      

        public Insertar_Cliente()
        {
            InitializeComponent();
        
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Cliente ventana = new Menu_Cliente();
            ventana.Show();
        }

        private void txtInsertarCliente_Click(object sender, EventArgs e)
        {

            limpiar();
        }
        private void limpiar()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";

            //DataTable Datos = conexion.consulta(String.Format("SELECT idCliente, nombre, apellido FROM cliente;"));
          // dvClientes.DataSource = Datos;
          // dvClientes.Refresh();


        }

        private void Insertar_Cliente_Load(object sender, EventArgs e)
        {
        //    DataTable Datos = conexion.consulta(String.Format("SELECT idCliente, nombre, apellido FROM cliente;"));
          //  dvClientes.DataSource = Datos;
           // dvClientes.Refresh();
        }

        private void dvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
