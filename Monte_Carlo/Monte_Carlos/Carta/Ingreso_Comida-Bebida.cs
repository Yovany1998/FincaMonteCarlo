using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Carta
{
    public partial class Ingreso_Comida : Form
    {
 

        public Ingreso_Comida()
        {
            InitializeComponent();
   
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Carta ventana = new Menu_Carta();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";


        }

        private void Ingreso_Comida_Load(object sender, EventArgs e)
        {
           
           // dvComida.DataSource = Datos;
           // dvComida.Refresh();
        }
    }
}
