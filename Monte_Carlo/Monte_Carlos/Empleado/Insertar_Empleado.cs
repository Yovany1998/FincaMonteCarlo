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
        MonteCarlo Variables = new MonteCarlo();
        long idEmpleado = 0;
        bool editar = false;
        int contador = 0;


        public Insertar_Empleado()
        {
            InitializeComponent();
           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
        
        }

        private void Insertar_Empleado_Load(object sender, EventArgs e)
        {
            var tEmpleado = from p in Variables.Empleados
                            select new
                            {
                                p.NIdentidad,
                                p.Nombre,
                                p.Apellidos,
                                p.Edad,
                                p.Cargo,
                                p.FechaIngreso
                                };

            dvEmpleado.DataSource = tEmpleado.CopyAnonymusToDataTable();
            dvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idEmpleado = 0;
            Limpiar();
            editar = false;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {


            if (editar)
            {
                MessageBox.Show("Modifique");
                var tEmpleado = Variables.Empleados.FirstOrDefault(x => x.IdEmpleado == idEmpleado);
                tEmpleado.NIdentidad = txtId.Text;
                tEmpleado.Nombre = txtNombre.Text;
                tEmpleado.Apellidos = txtApellido.Text;
                tEmpleado.Edad = Convert.ToInt32(txtEdad.Text);
                tEmpleado.FechaIngreso = DateTime.Today;
                tEmpleado.Cargo = cmbCargo.SelectedItem.ToString();

                Variables.SaveChanges();
            }
            else
            {
                MessageBox.Show("Guarde");
                Empleados tbEmpleado = new Empleados();
                tbEmpleado.NIdentidad = txtId.Text;
                tbEmpleado.Nombre = txtNombre.Text;
                tbEmpleado.Apellidos = txtApellido.Text;
                tbEmpleado.Edad = Convert.ToInt32(txtEdad.Text);
                tbEmpleado.FechaIngreso = DateTime.Today;
                tbEmpleado.Cargo = cmbCargo.SelectedItem.ToString();
                Variables.Empleados.Add(tbEmpleado);
                Variables.SaveChanges();
            }

            Limpiar();
            editar = false;
            idEmpleado = 0;

            var tblEmpleado = from p in Variables.Empleados
                                 select new
                                 {
                                     p.NIdentidad,
                                     p.Nombre,
                                     p.Apellidos,
                                     p.Edad,
                                     p.Cargo,
                                     p.FechaIngreso

                                 };
            dvEmpleado.DataSource = tblEmpleado.CopyAnonymusToDataTable();

            MessageBox.Show("Informacion guardada!");
            Limpiar();

        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            cmbCargo.SelectedIndex = cmbCargo.SelectedIndex = cmbCargo.SelectedIndex = -1;

        }

        private void dvempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
