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
    public partial class Introducir_bebidas : Form
    {
        private Bebidas bebidas;
        Conexion conexion;

        public Introducir_bebidas()
        {
            InitializeComponent();
            bebidas = new Bebidas();
            conexion = new Conexion();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Carta ventana = new Menu_Carta();
            ventana.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bebidas.NombreBebida = txtNombre.Text;
            bebidas.Precio = Convert.ToDouble(txtprecio.Text);
            bebidas.Descripcion = txtDescripcion.Text;

            if (bebidas.Guardar())
            {
                MessageBox.Show("Registro guardado correctamente", "bebida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Format("Error\n{0}", bebidas.Error.ToString()), "bebida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtprecio.Text = "";
            txtDescripcion.Text = "";

            DataTable Datos = conexion.consulta(String.Format("SELECT idBebida, nombre, precio, descripcion FROM bebida;"));
            dvBebidas.DataSource = Datos;
            dvBebidas.Refresh();


        }
    }
}
