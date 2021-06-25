using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Venta
{
    public partial class Pago : Form
    {

        Conexion conexion;
        private int state;
        private Ventas venta;

        public Pago()
        {
            InitializeComponent();
            venta = new Ventas();
            conexion = new Conexion();
        }

        private void BtnGenerarPago_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            Generar_Venta ventana = new Generar_Venta();
            ventana.Show();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            string id;
            id = Convert.ToString(conexion.consulta(string.Format("SELECT Max(idVenta) from DetalleDeFactura")).Rows[0][0].ToString());
            Total.Text = Convert.ToString(conexion.consulta(string.Format("SELECT SUM(Total) from DetalleDeFactura where idVenta = {0}", id)).Rows[0][0].ToString());
            DataTable Datos = conexion.consulta(String.Format("SELECT idVenta as 'Numero De Venta',idFactura as 'Numero De Factura',idPedido as 'Pedido',precio as 'Precio',Cantidad,Total FROM DetalleDeFactura  where idFactura = {0};",id));
            dgvVenta.DataSource = Datos;
            dgvVenta.Refresh();
        }
    }
}
