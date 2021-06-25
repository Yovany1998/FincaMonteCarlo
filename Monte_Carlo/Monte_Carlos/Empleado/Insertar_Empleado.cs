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
    public partial class Insertar_Empleado : Form
    {
     

        public Insertar_Empleado()
        {
            InitializeComponent();
           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Empleado ventana = new Menu_Empleado();
            ventana.Show();
        }

        private void Insertar_Empleado_Load(object sender, EventArgs e)
        {
           // DataTable Datos = conexion.consulta(String.Format("SELECT idEmpleado, nombre, apeliido, edad, cargo FROM empleado;"));
            //dvempleado.DataSource = Datos;
            //dvempleado.Refresh();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
           
            limpiar();
        }

        private void limpiar()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            txtcargo.Text = "";

           // DataTable Datos = conexion.consulta(String.Format("SELECT idEmpleado, nombre, apeliido, edad, cargo FROM empleado;"));
            //dvempleado.DataSource = Datos;
            //dvempleado.Refresh();


        }

        private void dvempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
