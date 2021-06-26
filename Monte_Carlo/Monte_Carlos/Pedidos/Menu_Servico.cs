using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Servicio
{
    public partial class Menu_Servico : Form
    {
        public Menu_Servico()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ventana = new Menu();
            ventana.Show();
        }

        private void btnInsertarPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insertar_Pedido ventana = new Insertar_Pedido();
            ventana.Show();
        }

        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Pedido ventana = new Modificar_Pedido();
            ventana.Show();
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eliminar_Pedido ventana = new Eliminar_Pedido();
            ventana.Show();
        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Pedido ventana = new Ver_Pedido();
            ventana.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
