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
        int Log;


        public Insertar_Empleado()
        {
            InitializeComponent();
           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
        
        }

        private void CargarDv()
        {
            var tEmpleado = from p in Variables.Empleados
                            select new
                            {
                                p.IdEmpleado,
                                p.NIdentidad,
                                p.Nombre,
                                p.Apellidos,
                                p.Edad,
                                p.Cargo,
                                p.FechaIngreso
                            };

            dvEmpleado.DataSource = tEmpleado.CopyAnonymusToDataTable();
        }
        private void Insertar_Empleado_Load(object sender, EventArgs e)
        {
            CargarDv();
            dvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idEmpleado = 0;
            Limpiar();
            editar = false;
            Log = 1;
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
            CargarDv();

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
        private void dvEmpleado_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                idEmpleado = Convert.ToInt64(dvEmpleado.SelectedCells[0].Value);
                var tEmpleado = Variables.Empleados.FirstOrDefault(x => x.IdEmpleado == idEmpleado);
                txtId.Text = tEmpleado.NIdentidad;
                txtNombre.Text = tEmpleado.Nombre;
                txtApellido.Text = tEmpleado.Apellidos;
                txtEdad.Text = Convert.ToString(tEmpleado.Edad);
                cmbCargo.Text = Convert.ToString(tEmpleado.Cargo);
      
                editar = true;

            }
            catch (Exception)
            {

            }

            if (Log == 1)
            {
                Limpiar();
            }
        }

        private void dvEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            if (Log == 1)
            {
                Log = 2;
            }
        }

        private void btnElimicar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                MessageBox.Show("Debe haber un registro seleccionado para poder borrarlo");
            }
            else
            {
                if (dvEmpleado.RowCount == 2)
                {
                    MessageBox.Show("Si eliminas este registro no podras acceder al programa");
                }
                else
                {

                    Variables.Empleados.RemoveRange(Variables.Empleados.Where(x => x.IdEmpleado == idEmpleado));
                    Variables.SaveChanges();
                    Limpiar();
                    CargarDv();
                }
            }
        }
    }
}
