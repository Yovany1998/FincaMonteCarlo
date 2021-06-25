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
    public partial class Menu_Empleado : Form
    {
        public Menu_Empleado()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ventana = new Menu();
            ventana.Show();
        }

        private void btnInsertarEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insertar_Empleado ventana = new Insertar_Empleado();
            ventana.Show();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Empleado ventana = new Modificar_Empleado();
            ventana.Show();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eliminar_Empleado ventana = new Eliminar_Empleado();
            ventana.Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Empleado ventana = new Ver_Empleado();
            ventana.Show();
        }
    }
}
