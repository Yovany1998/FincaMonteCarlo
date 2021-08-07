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
        private int Contador;
        public Inicio()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelCentral.Controls.Count > 0)
                this.PanelCentral.Controls.RemoveAt(0);
          
      
         if(Contador < 100)
            {
                Barras.Value = 0;
                Contador++;
                for (int x = 0; x < 100; x++)
                {
                    Barras.Value++;

                }
                Form fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PanelCentral.Controls.Add(fh);
                this.PanelCentral.Tag = fh;
                fh.Show();

            }
            else
            {
                Contador = 0;
            }

            Barras.Visible = true;
          
           

        }
        private void btncliente_Click(object sender, EventArgs e)
        {
           
            AbrirFormEnPanel(new Cliente.Insertar_Cliente());
        }

        private void btnservicio_Click(object sender, EventArgs e)
        {
            
            AbrirFormEnPanel(new Ver_Pedido());
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new Insertar_Empleado());
        }

        private void Venta_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new Generar_Venta());
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Reservaciones.Insertar_Reservaciones());
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

  

        private void button1_Click(object sender, EventArgs e)
        {
    
            AbrirFormEnPanel(new Ingreso_Comida());

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Demas.Entrada());
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

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Salidas.Ingresar_Compras());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Demas.Ingresar_Usuario());
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ventana = new Login();
            ventana.Show();

        }
    }
}
