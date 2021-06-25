using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Reservaciones
{
    public partial class Insertar_Reservaciones : Form
    {
      

        public Insertar_Reservaciones()
        {
            InitializeComponent();
      
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reservaciones ventana = new Menu_Reservaciones();
            ventana.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

           
            limpiar();
        }
        private void limpiar()
        {
            txtCodigo.Text = "";
            txtMesa.Text = "";
            txtHora.Text = "";

           
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reservaciones ventana = new Menu_Reservaciones();
            ventana.Show();
        }

        private void Insertar_Reservaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
