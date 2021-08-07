using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Monte_Carlos
{
    public partial class Login : Form
    {
        MonteCarlo entity = new MonteCarlo();
        public Login()
        {
            InitializeComponent();
           
        }
    private void Limpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {


            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Ingrese usuario");
                return;
            }

            if (txtContraseña.Text == string.Empty)
            {
                MessageBox.Show("Ingrese contraseña");
                return;
            }
            string pass = Hash.obtenerHash256(txtContraseña.Text);
                 var tUsuarios = entity.Usuario.FirstOrDefault(x => x.Nombre == txtUsuario.Text && x.Contrasena == pass && x.Estado == true);

            if (tUsuarios == null)
            {
                MessageBox.Show("Usuario o Contrasenia incorrecto");
                Limpiar();
                return;
            }
            else
            {
                Limpiar();

                this.Hide();
                Inicio ventana = new Inicio();
                ventana.Show();

            }



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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '●';
        }

        private void txtContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            txtContraseña.Text = "";
            panel2.BackColor = Color.Yellow;
        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Text = "";
            panel1.BackColor = Color.Yellow;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CargaDv();

        }


        private void CargaDv()
        {
            var tUsuario = from p in entity.Usuario
                           select new
                           {
                               p.IdUsuario,

                           };
            if (tUsuario.Count() == 0)
            {
                string pass = Hash.obtenerHash256("1234");
                Usuario tbUsuario = new Usuario
                {
                    NIdentidad = "1306-1998-00185",
                    Nombre = "Coba",
                    Contrasena = pass,
                    Estado = Convert.ToBoolean(1),            };
            entity.Usuario.Add(tbUsuario);
            entity.SaveChanges();
        }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void horafecha_Tick_1(object sender, EventArgs e)
        {
           
                lblHora.Text = DateTime.Now.ToShortTimeString();
                lblFecha.Text = DateTime.Now.ToLongDateString();
            
        }
    }
}
