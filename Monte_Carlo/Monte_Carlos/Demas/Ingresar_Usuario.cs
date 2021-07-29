using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Demas
{
    public partial class Ingresar_Usuario : Form
    {
        MonteCarlo Variables = new MonteCarlo();
        long idUsuario = 0;
        bool editar = false;
        int contador = 0;
        public Ingresar_Usuario()
        {
            InitializeComponent();
        }

        private void Ingresar_Usuario_Load(object sender, EventArgs e)
        {
            var tUsuario = from p in Variables.Usuario
                                select new
                                {
                                    p.IdUsuario,
                                    p.NIdentidad,
                                    p.Nombre,
                                    p.Estado
                                };

            dvUsuario.DataSource = tUsuario.CopyAnonymusToDataTable();
            dvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idUsuario = 0;
            Limpiar();
            editar = false;
        }
        private void Limpiar()
        {
            txtContrasena.Text = "";
            txtIdentidad.Text = "";
            txtNombre.Text = "";
            //  ActivoInactivo = true;
          
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese el Nombre");
                return;
            }
            if (txtIdentidad.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el precio");
                return;
            }
            if (txtContrasena.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar su contraseña");
                return;
            }


            if (editar)
            {
                MessageBox.Show("Modifique");
                var tusuario = Variables.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);
                tusuario.NIdentidad = txtIdentidad.Text;
                tusuario.Nombre = txtNombre.Text;
                tusuario.Contrasena = txtContrasena.Text;
                tusuario.Estado = Convert.ToBoolean(ActivoInactivo.Text);


                Variables.SaveChanges();
            }
            else
            {
                MessageBox.Show("Guarde");
                Usuario tbUsuario = new Usuario();
                tbUsuario.NIdentidad = txtIdentidad.Text;
                tbUsuario.Nombre = txtNombre.Text;
                tbUsuario.Contrasena = txtContrasena.Text;
                tbUsuario.Estado = Convert.ToBoolean(ActivoInactivo.Text);
                Variables.Usuario.Add(tbUsuario);
                Variables.SaveChanges();
            }

            Limpiar();
            editar = false;
            idUsuario = 0;

            var tUsuario = from p in Variables.Usuario
                           select new
                           {
                               p.IdUsuario,
                               p.NIdentidad,
                               p.Nombre,
                               p.Estado
                           };

            dvUsuario.DataSource = tUsuario.CopyAnonymusToDataTable();

            MessageBox.Show("Informacion guardada!");
            Limpiar();

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            contador++;
            if (dvUsuario.RowCount > 1)
            {
                try
                {
                  
                    idUsuario = Convert.ToInt64(dvUsuario.SelectedCells[0].Value);
                    var tUsuario = Variables.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);
                    txtNombre.Text = tUsuario.Nombre;
                    txtIdentidad.Text = tUsuario.NIdentidad;
                    txtContrasena.Text = tUsuario.Contrasena;
                    editar = true;
                }
                catch (Exception)
                {
                }
            }
           
        }
    }
}
