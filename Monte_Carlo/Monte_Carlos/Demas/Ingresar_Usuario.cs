using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        public class Hash
        {
            public static string obtenerHash256(string text)
            {

                byte[] bytes = Encoding.Unicode.GetBytes(text);
                SHA256Managed hashString = new SHA256Managed();

                byte[] hash = hashString.ComputeHash(bytes);
                string hashStr = string.Empty;

                foreach (byte x in hash)
                {
                    hashStr += String.Format("{0:x2}", x);
                }

                return hashStr;

            }
        }
        private void Ingresar_Usuario_Load(object sender, EventArgs e)
        {
            CargaDv();
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
            ActivoInactivo.Checked = false;
            idUsuario = 0;
            editar = false;

        }
        private void CargaDv()
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

            string pass = Hash.obtenerHash256(txtContrasena.Text);

            if (editar)
            {
                MessageBox.Show("Modifique");
                var tusuario = Variables.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);
                tusuario.NIdentidad = txtIdentidad.Text;
                tusuario.Nombre = txtNombre.Text;
                tusuario.Contrasena = pass;
                tusuario.Estado = ActivoInactivo.Checked; 
                Variables.SaveChanges();
            }
            else
            {
                MessageBox.Show("Guarde");
                Usuario tbUsuario = new Usuario();
                tbUsuario.NIdentidad = txtIdentidad.Text;
                tbUsuario.Nombre = txtNombre.Text;
                tbUsuario.Contrasena = pass;
                tbUsuario.Estado = ActivoInactivo.Checked;
                Variables.Usuario.Add(tbUsuario);
                Variables.SaveChanges();
            }

            Limpiar();
            editar = false;
            idUsuario = 0;
            CargaDv();

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
                    txtContrasena.Text = "**********";
                    editar = true;
                }
                catch (Exception)
                {
                }
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe haber un registro seleccionado para poder borrarlo");
            }
            else
            {
                if (dvUsuario.RowCount == 2)
                {
                    MessageBox.Show("Si eliminas este registro no podras acceder al programa");
                }
                else
                {

                    Variables.Usuario.RemoveRange(Variables.Usuario.Where(x => x.IdUsuario == idUsuario));
                    Variables.SaveChanges();
                    Limpiar();
                    CargaDv();
                }
            }
           
        }
    }
}
