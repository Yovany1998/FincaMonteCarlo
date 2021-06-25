using Monte_Carlos.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos
{
    public partial class Menu_Cliente : Form
    {
        public Menu_Cliente()
        {
            InitializeComponent();
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insertar_Cliente ventana = new Insertar_Cliente();
            ventana.Show();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Cliente ventana = new Modificar_Cliente();
            ventana.Show();
        }

        private void btnVerCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Cliente ventana = new Ver_Cliente();
            ventana.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ventana = new Menu();
            ventana.Show();
        }
    }
}
