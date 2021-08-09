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
            dvEmpleado.ClearSelection();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            String Identidad = txtId.Text;
      
            char guion = Convert.ToChar("-");
            char Guion1 = txtId.Text[4];
            char Guion2 = txtId.Text[9];
            if (Guion1 != guion || Guion2 != guion)
            {
                MessageBox.Show("El numero de idententidad debe llevar guiones o esta mal escrito");
                txtId.Focus();
                return;
            }


            var TamanoIdentidad = txtId.TextLength;
            if (TamanoIdentidad < 15)
            {
                MessageBox.Show("El numero de identidad es muy corto");
                txtId.Focus();
                return;
            }
             if(txtId.Text == "")
            {
                MessageBox.Show("Ingrese el numero de identidad");
                txtId.Focus();
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del empleado");
                txtNombre.Focus();
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido del empleado");
                txtApellido.Focus();
                return;
            }
            if (txtEdad.Text == "")
            {
                MessageBox.Show("Ingrese la edad");
                txtEdad.Focus();
                return;
            }
            if (Convert.ToInt32(txtEdad.Text) <16)
            {
                MessageBox.Show("La edad del empleado debe de ser mayor a 16");
                txtEdad.Focus();
                return;
            }


            if (editar)
            {

                MessageBox.Show("Empleado modificado!");
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
                var tEmpleados = Variables.Empleados.FirstOrDefault(x => x.NIdentidad == Identidad);
                if (tEmpleados != null)
                {
                    MessageBox.Show("El numero de identidad ya existe");
                    txtId.Focus();
                    return;
                }
                MessageBox.Show("Empleado Guardado!");
                Empleados tbEmpleado = new Empleados
                {
                    NIdentidad = txtId.Text,
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    Edad = Convert.ToInt32(txtEdad.Text),
                    FechaIngreso = DateTime.Today,
                    Cargo = cmbCargo.SelectedItem.ToString()
                };
                Variables.Empleados.Add(tbEmpleado);
                Variables.SaveChanges();
            }
            editar = false;
            idEmpleado = 0;
            CargarDv();
            Limpiar();
        }

        private void Limpiar()
        {
            dvEmpleado.ClearSelection();
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            cmbCargo.SelectedIndex = cmbCargo.SelectedIndex = cmbCargo.SelectedIndex = -1;
            editar = false;

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
                dvEmpleado.ClearSelection();
                editar = false;
            }

            if (Log == 1)
            {
                dvEmpleado.ClearSelection();
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
                    Variables.Empleados.RemoveRange(Variables.Empleados.Where(x => x.IdEmpleado == idEmpleado));
                    Variables.SaveChanges();
                    Limpiar();
                    CargarDv();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
