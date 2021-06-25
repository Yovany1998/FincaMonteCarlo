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
        private Comida comida;
        Conexion conexion;

        public Ingreso_Comida()
        {
            InitializeComponent();
            comida = new Comida();
            conexion = new Conexion();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Carta ventana = new Menu_Carta();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comida.NombreComida = txtNombre.Text;
            comida.Precio = Convert.ToDouble(txtPrecio.Text);
            comida.Descripcion = txtDescripcion.Text;

            if (comida.Guardar())
            {
                MessageBox.Show("Registro guardado correctamente", "comida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Format("Error\n{0}", comida.Error.ToString()), "comida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";

            DataTable Datos = conexion.consulta(String.Format("SELECT idComida, comida, precio, descripcion FROM comida;"));
            dvComida.DataSource = Datos;
            dvComida.Refresh();


        }

        private void Ingreso_Comida_Load(object sender, EventArgs e)
        {
            DataTable Datos = conexion.consulta(String.Format("SELECT idComida,comida, precio, descripcion FROM comida;"));
            dvComida.DataSource = Datos;
            dvComida.Refresh();
        }
    }
}
