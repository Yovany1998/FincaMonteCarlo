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
using System.Runtime.InteropServices;

namespace Monte_Carlos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelCentral.Controls.Count > 0)
                this.PanelCentral.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelCentral.Controls.Add(fh);
            this.PanelCentral.Tag = fh;
            fh.Show();

        }
        private void btncliente_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Menu_Cliente ventana = new Menu_Cliente();
            //ventana.Show();
            AbrirFormEnPanel(new Cliente.Insertar_Cliente());
        }

        private void btnservicio_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Menu_Servico ventana = new Menu_Servico();
            //ventana.Show();
            AbrirFormEnPanel(new Ver_Pedido());
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Menu_Empleado ventana = new Menu_Empleado();
            //ventana.Show();
            AbrirFormEnPanel(new Insertar_Empleado());
        }

        private void Venta_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Menu_Venta ventana = new Menu_Venta();
            //ventana.Show();
            AbrirFormEnPanel(new Generar_Venta());
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            // this.Hide();
            // Menu_Reservaciones ventana = new Menu_Reservacion();
            // ventana.Show();
            AbrirFormEnPanel(new Insertar_Reservaciones());
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
            Menu_Carta ventana = new Menu_Carta();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Menu_Carta ventana = new Menu_Carta();
            //ventana.Show();
            AbrirFormEnPanel(new Ingreso_Comida());

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GrandePeque_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            GrandePeque.Visible = false;
            Peque.Visible = true;
        }

        private void Peque_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Peque.Visible = false;
            GrandePeque.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PanelArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Factura());
        }
    }
}
