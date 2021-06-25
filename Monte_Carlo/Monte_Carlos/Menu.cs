using Monte_Carlos.Carta;
using Monte_Carlos.Empleado;
using Monte_Carlos.Reservaciones;
using Monte_Carlos.Servicio;
using Monte_Carlos.Venta;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Cliente ventana = new Menu_Cliente();
            ventana.Show();
        }

        private void btnservicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Servico ventana = new Menu_Servico();
            ventana.Show();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Empleado ventana = new Menu_Empleado();
            ventana.Show();
        }

        private void Venta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Venta ventana = new Menu_Venta();
            ventana.Show();
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reservaciones ventana = new Menu_Reservaciones();
            ventana.Show();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString(); 
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reservaciones ventana = new Menu_Reservaciones();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Carta ventana = new Menu_Carta();
            ventana.Show();

        }
    }
}
