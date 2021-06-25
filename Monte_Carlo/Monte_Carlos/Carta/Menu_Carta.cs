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

namespace Monte_Carlos.Carta
{
    public partial class Menu_Carta : Form
    {
        public Menu_Carta()
        {
            InitializeComponent();
        }

        private void btnInsertarComida_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingreso_Comida ventana = new Ingreso_Comida();
            ventana.Show();
        }

        private void btnInsertarBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Introducir_bebidas ventana = new Introducir_bebidas();
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
