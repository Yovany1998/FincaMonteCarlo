using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Finca_Monte_Carlo
{
    public partial class Menu_Venta : Form
    {
        public Menu_Venta()
        {
            InitializeComponent();
        }

        private void btnInsertarPedido_Click(object sender, EventArgs e)
        {
            Generar_Venta ventana = new Generar_Venta();
            this.Hide();
          // ventana.Show();
        }

        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            Factura ventana = new Factura();
          //  ventana.Show();
        }
    }
}
