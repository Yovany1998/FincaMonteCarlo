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
    public partial class Menu_Reservaciones : Form
    {
        public Menu_Reservaciones()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ventana = new Menu();
            ventana.Show();
        }

        private void btnInsertarReservacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insertar_Reservaciones ventana = new Insertar_Reservaciones();
            ventana.Show();
        }

        private void btnModificarReservacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Reservaciones ventana = new Modificar_Reservaciones();
            ventana.Show();
        }

        private void btnEliminarReservacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eliminar_Reservaciones ventana = new Eliminar_Reservaciones();
            ventana.Show();
        }

        private void btnVerReservacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Reservaciones ventana = new Ver_Reservaciones();
            ventana.Show();
        }
    }
}
