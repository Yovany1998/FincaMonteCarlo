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
    public partial class Menu_Venta : Form
    {
        public Menu_Venta()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ventana = new Menu();
            ventana.Show();
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Generar_Venta ventana = new Generar_Venta();
            ventana.Show();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            this.Hide();
            Factura ventana = new Factura();
            ventana.Show();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu ventana = new Menu();
            ventana.Show();

        }
    }
}
