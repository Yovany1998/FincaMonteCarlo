using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Empleado
{
    public partial class Ver_Empleado : Form
    {
        public Ver_Empleado()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Empleado ventana = new Menu_Empleado();
            ventana.Show();
        }
    }
}
