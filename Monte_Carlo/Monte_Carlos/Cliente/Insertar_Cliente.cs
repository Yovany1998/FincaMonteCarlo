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
        private Cliente cliente;
        Conexion conexion;

        public Insertar_Cliente()
        {
            InitializeComponent();
            cliente = new Cliente();
            conexion = new Conexion();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Cliente ventana = new Menu_Cliente();
            ventana.Show();
        }

        private void txtInsertarCliente_Click(object sender, EventArgs e)
        {

            cliente.IdCliente = txtIdCliente.Text;
            cliente.NombreCliente = txtNombre.Text;
            cliente.ApellidoCliente = txtApellido.Text;
            if (cliente.Guardar())
            {
                MessageBox.Show("Registro guardado correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Format("Error\n{0}", cliente.Error.ToString()), "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
        }
        private void limpiar()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";

            DataTable Datos = conexion.consulta(String.Format("SELECT idCliente, nombre, apellido FROM cliente;"));
            dvClientes.DataSource = Datos;
            dvClientes.Refresh();


        }

        private void Insertar_Cliente_Load(object sender, EventArgs e)
        {
            DataTable Datos = conexion.consulta(String.Format("SELECT idCliente, nombre, apellido FROM cliente;"));
            dvClientes.DataSource = Datos;
            dvClientes.Refresh();
        }

        private void dvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
