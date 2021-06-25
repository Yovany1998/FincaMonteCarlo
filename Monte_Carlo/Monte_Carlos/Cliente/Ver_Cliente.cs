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
    public partial class Ver_Cliente : Form
    {
        Conexion conexion;
        public Ver_Cliente()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Cliente ventana = new Menu_Cliente();
            ventana.Show();
        }

        private void Ver_Cliente_Load(object sender, EventArgs e)
        {
            DataTable Datos = conexion.consulta(String.Format("SELECT idCliente, nombre, apellido FROM cliente;"));
            dvClientes.DataSource = Datos;
            dvClientes.Refresh();
        }
    }
}
