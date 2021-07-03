using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Cliente
{
    public partial class Insertar_Cliente : Form
    {
        Finca_Monte_CarloEntities1 Variables = new Finca_Monte_CarloEntities1();
        long idCliente = 0;
        bool editar = false;

        public Insertar_Cliente()
        {
            InitializeComponent();
        
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Cliente ventana = new Menu_Cliente();
            ventana.Show();
        }

        private void txtInsertarCliente_Click(object sender, EventArgs e)
        {

            if (txtIdentidad.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese el numero de identidad");
                return;
            }
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el nombre");
                return;
            }
            if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el Apellido");
                return;
            }
            if (txtEdad.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar la edad");
                return;
            }
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el nombre");
                return;
            }
            if (txtTelefono.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el numero telefonico");
                return;
            }

            if (editar)
            {
                MessageBox.Show("Modifique");
                var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente == idCliente);
                tCliente.Identidad = txtIdentidad.Text;
                tCliente.Nombre = txtNombre.Text;
                tCliente.Apellido = txtApellido.Text;
                tCliente.Edad = Convert.ToInt32(txtEdad.Text);
                tCliente.Telefono = Convert.ToInt32(txtTelefono.Text);
                tCliente.Correo = txtCorreo.Text;

                Variables.SaveChanges();
            }
            else
            {
                MessageBox.Show("Guarde");
                Clientes tbClientes = new Clientes();
                tbClientes.Identidad = txtIdentidad.Text;
                tbClientes.Nombre = txtNombre.Text;
                tbClientes.Apellido = txtApellido.Text;
                tbClientes.Edad = Convert.ToInt32(txtEdad.Text);
                tbClientes.Telefono = Convert.ToInt32(txtTelefono.Text);
                tbClientes.Correo = txtCorreo.Text;
                Variables.Clientes.Add(tbClientes);

                Variables.SaveChanges();
            }
            limpiar();
            editar = false;
            idCliente = 0;

            var tClientes = from p in Variables.Clientes
                                select new
                                {
                                    p.IdCliente,
                                    p.Identidad,
                                    p.Nombre,
                                    p.Apellido,
                                    p.Edad,
                                    p.Telefono,
                                    p.Correo,
                                };
            dvClientes.DataSource = tClientes.CopyAnonymusToDataTable();

            MessageBox.Show("Informacion guardada!");
            limpiar();
        }
        private void limpiar()
        {
            txtIdentidad.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void Insertar_Cliente_Load(object sender, EventArgs e)
        {
            
            var tCliente = from p in Variables.Clientes
                           select new
                                 {
                               p.IdCliente,
                               p.Identidad,
                               p.Nombre,
                               p.Apellido,
                               p.Edad,
                               p.Telefono,
                               p.Correo,
                           };
            dvClientes.DataSource = tCliente.CopyAnonymusToDataTable();
            dvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idCliente = 0;
            limpiar();
            editar = false;

        }

        private void dvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dvClientes.RowCount > 1)
            {
              //  MessageBox.Show("Entre");
              //  int contado = 0;
               // contado = contado + 1;

                try
                {
                  //  MessageBox.Show(Convert.ToString(contado));
                    idCliente = Convert.ToInt64(dvClientes.SelectedCells[0].Value);
                    var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente == idCliente);
                    txtIdentidad.Text = tCliente.Identidad;
                    txtNombre.Text = tCliente.Nombre;
                    txtApellido.Text = tCliente.Apellido;
                    txtEdad.Text = Convert.ToString(tCliente.Edad);
                    txtTelefono.Text = Convert.ToString(tCliente.Telefono);
                    txtCorreo.Text = tCliente.Correo;
                    editar = true;

                }
                catch (Exception)
                {

                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            editar = false;
            idCliente = 0;
        }

        
    }
}
