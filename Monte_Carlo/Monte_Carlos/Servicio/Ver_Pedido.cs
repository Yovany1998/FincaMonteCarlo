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
    public partial class Ver_Pedido : Form
    {
        Conexion conexion;
        public Ver_Pedido()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Servico ventana = new Menu_Servico();
            ventana.Show();
        }

        private void Ver_Pedido_Load(object sender, EventArgs e)
        {
            DataTable Datos = conexion.consulta(String.Format("SELECT idPedido as 'Numero de pedido',idcomida as 'Codido de comida',idbebida as 'Codido de bebida' FROM pedido;"));
            dvPedido.DataSource = Datos;
            dvPedido.Refresh();
        }
    }
}
