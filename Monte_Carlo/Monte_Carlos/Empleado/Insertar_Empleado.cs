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
        private Empleado empleado;
        Conexion conexion;

        public Insertar_Empleado()
        {
            InitializeComponent();
            empleado = new Empleado();
            conexion = new Conexion();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Empleado ventana = new Menu_Empleado();
            ventana.Show();
        }

        private void Insertar_Empleado_Load(object sender, EventArgs e)
        {
            DataTable Datos = conexion.consulta(String.Format("SELECT idEmpleado, nombre, apeliido, edad, cargo FROM empleado;"));
            dvempleado.DataSource = Datos;
            dvempleado.Refresh();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            empleado.IdEmpleado = txtid.Text;
            empleado.NombreEmpleado = txtnombre.Text;
            empleado.ApellidoEmpleado = txtapellido.Text;
            empleado.Edad = Convert.ToInt32(txtedad.Text);
            empleado.Cargo = txtcargo.Text;
            if (empleado.Guardar())
            {
                MessageBox.Show("Registro guardado Correctamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Format("Error\n{0}", empleado.Error.ToString()), "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
        }

        private void limpiar()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            txtcargo.Text = "";

            DataTable Datos = conexion.consulta(String.Format("SELECT idEmpleado, nombre, apeliido, edad, cargo FROM empleado;"));
            dvempleado.DataSource = Datos;
            dvempleado.Refresh();


        }

        private void dvempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
