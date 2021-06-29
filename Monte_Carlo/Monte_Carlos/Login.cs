using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            this.Hide();
            Inicio ventana = new Inicio();
            ventana.Show();

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
            panel2.BackColor = Color.FromArgb(217, 4, 142);
        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Text = "";
            panel1.BackColor = Color.FromArgb(217, 4, 142);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
