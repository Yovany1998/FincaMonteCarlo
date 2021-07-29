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
        MonteCarlo Variables = new MonteCarlo();
        long idCliente = 0;
        bool editar = false;
        int ContadorCliente = 0;

        public Insertar_Cliente()
        {
            InitializeComponent();
        
        }


        private void txtInsertarCliente_Click(object sender, EventArgs e)
        {
            String Identidad = txtIdentidad.Text;


            var tClientee = Variables.Clientes.FirstOrDefault(x => x.Identidad == Identidad);

            if (tClientee != null)              
            {
                MessageBox.Show("El numero de identidad ya existe");
                txtIdentidad.Focus();
                return;
            }

            var TamanoIdentidad = txtIdentidad.TextLength;
            if (TamanoIdentidad < 15)
            {
                MessageBox.Show("El numero de identidad es muy corto");
                txtIdentidad.Focus();
                return;
            }

            char guion = Convert.ToChar("-");
            char Guion1 = txtIdentidad.Text[4];
            char Guion2 = txtIdentidad.Text[9];
       if(Guion1 != guion ||  Guion2 != guion) {
                MessageBox.Show("El numero de idententidad debe llevar guiones o esta mal escrito");
                txtIdentidad.Focus();
                return;
            }


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

            if (txtTelefono.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el numero telefonico");
                return;
            }
            var TamanoTelefono = txtTelefono.TextLength;
            if (TamanoTelefono < 8)
            {
                MessageBox.Show("El numero de telefono es muy corto");
                txtTelefono.Focus();
                return;
            }

            //Agregar validacion para 2
            char TigoClaro = txtTelefono.Text[0];
            if(TigoClaro !=Convert.ToChar("3") || TigoClaro != Convert.ToChar("8") || TigoClaro != Convert.ToChar("9"))
            {
                MessageBox.Show("El numero de telefono debe ser tigo o claro");
            }

            if (txtCorreo.Text != "")
            {
                int NArroba = 0;
                var TamanoCorreo = txtCorreo.TextLength;
                for (int r=0; r < TamanoCorreo; r++) {
                    char Arroba = txtCorreo.Text[r];
                    if ( Arroba == Convert.ToChar("@"))
                    {
                         NArroba ++;
                    }

                }

                if(NArroba == 0)
                {
                    MessageBox.Show("El correo ingresado debe llevar @");
                    txtCorreo.Focus();
                    return;
                }
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
            Limpiar();
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
            Limpiar();
        }
        private void Limpiar()
        {
            txtIdentidad.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            idCliente = 0;
            editar = false;
            
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
            Limpiar();
        }

        private void dvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvClientes_SelectionChanged(object sender, EventArgs e)
        {
             ContadorCliente++;
            if (dvClientes.RowCount > 1)
            {
                try
                {
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
            if(ContadorCliente == 5)
            {
                Limpiar();
            }
          

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
