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
        private int conta = 0;
        int registro=0;
        int log;
        DateTime FechaRegistro;
        double total = 0.0;
        long idVenta = 0;
        private bool VentaValida = true;
        private int contadorcomida = 0;
        MonteCarlo Variables = new MonteCarlo();
        long idReservacion = 0;
        long idDetalleReservacion = 0;
        string nombre = "";
        bool editar = false;
        bool editarDetalle = false;
        bool ValidarComida = false;
        bool ValidarCliente = false;
        double impuesto = 0.0;
        double TotImpuesto = 0.0;
        double TotSubtotal = 0.0;
        double Subtotal = 0.0;
        DataTable dtVentas = new DataTable();

        public Insertar_Reservaciones()
        {
            InitializeComponent();
                 
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {

           
            Limpiar();
        }
        private void Limpiar()
        {
            txtCantidad.Text = "";
            txtApellido.Text = "";
            txtHora.Text = "";
            txtLugar.Text = "";
            cmbCliente.SelectedIndex = cmbCliente.SelectedIndex = cmbCliente.SelectedIndex = -1;
            cmbComida.SelectedIndex = cmbComida.SelectedIndex = cmbComida.SelectedIndex = -1;
          //  dvRegistro.ClearSelection();
           // dvReservacion.ClearSelection();
        }
        private void CargaDetalleDv()
        {

            var tbReservacion = from p in Variables.DetalleReservacion
                                select new
                                {
                                  p.IdDetalleReservacion,
                                  p.Pedido,
                                  p.Cantidad

                                };
            dvReservacion.DataSource = tbReservacion.CopyAnonymusToDataTable();
        }
        private void CargaDv()
        {

            var tbReservacion  = from p in Variables.Reservacion
                                 select new
                                 {
                                     p.IdReservacion,
                                     p.Fecha,
                                     p.Cliente,
                                     p.Apellido,
                                     p.Zona,
                                     p.Hora,

                                 };
            dvRegistro.DataSource = tbReservacion.CopyAnonymusToDataTable();
        }
     

        private void Insertar_Reservaciones_Load(object sender, EventArgs e)
        {
            log = 1;
            var tMod = from mod in Variables.Clientes
                       select new
                       {
                           mod.IdCliente,
                           mod.Nombre,
                       };

            DataTable dtMod = tMod.CopyAnonymusToDataTable();
            cmbCliente.DataSource = dtMod;
            cmbCliente.ValueMember = dtMod.Columns[0].ColumnName;
            cmbCliente.DisplayMember = dtMod.Columns[1].ColumnName;
            nombre = (cmbCliente.DisplayMember = dtMod.Columns[1].ColumnName);
            //Comida Bebida
            var tcomi = from c in Variables.Menu
                        select new
                        {
                            c.IdComidaBebida,
                            c.Nombre,
                        };
            DataTable dtcomi = tcomi.CopyAnonymusToDataTable();
            cmbComida.DataSource = dtcomi;
            cmbComida.ValueMember = dtcomi.Columns[0].ColumnName;
            cmbComida.DisplayMember = dtcomi.Columns[1].ColumnName;
            CargaDv();
            Limpiar();
            ValidarCliente = false;
            dvRegistro.ClearSelection();
         
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            if (registro == 0)
            {
                cmbCliente.Enabled = false;
                txtHora.Enabled = false;
                txtLugar.Enabled = false;
                Fecha.Enabled = false;
                if (editar)
                {
                    MessageBox.Show("Modifique");
                    var tReservacion = Variables.Reservacion.FirstOrDefault(x => x.IdReservacion == idReservacion);
                    tReservacion.Cliente = cmbCliente.SelectedItem.ToString();
                    tReservacion.Apellido = Convert.ToString(txtApellido.Text);
                    tReservacion.Zona = Convert.ToString(txtLugar.Text);
                    tReservacion.Fecha = Convert.ToDateTime(Fecha.Text);
                    tReservacion.Hora = Convert.ToString(txtHora.Text);

                    Variables.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Guarde");
                    Reservacion tbReservacion = new Reservacion();
                    tbReservacion.Cliente = cmbCliente.SelectedItem.ToString();
                    tbReservacion.Apellido = Convert.ToString(txtApellido.Text);
                    tbReservacion.Zona = Convert.ToString(txtLugar.Text);
                    tbReservacion.Fecha = Convert.ToDateTime(Fecha.Text);
                    FechaRegistro = Convert.ToDateTime(Fecha.Text);
                    tbReservacion.Hora = Convert.ToString(txtHora.Text);
                    Variables.Reservacion.Add(tbReservacion);
                    Variables.SaveChanges();

                    //area de detalle
                    DetalleReservacion tbReservaciones = new DetalleReservacion();
                    long comida = Convert.ToInt32(cmbComida.SelectedItem.ToString());
                    var tComida = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == comida);
                    tbReservaciones.Pedido = tComida.Nombre;
                    tbReservaciones.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    tbReservaciones.Fecha = Convert.ToDateTime(Fecha.Text);
                    FechaRegistro = Convert.ToDateTime(Fecha.Text);
                    tbReservacion.Hora = Convert.ToString(txtHora.Text);
                    Variables.DetalleReservacion.Add(tbReservaciones);
                    Variables.SaveChanges();
                }

                Limpiar();
                editar = false;
                idReservacion = 0;

                CargaDv();

                MessageBox.Show("Informacion guardada!");
                Limpiar();
                registro = 1;
            }
            else
            {
                if (editarDetalle)
                {
                    MessageBox.Show("Modifique el detalle");
                    var tDetalle = Variables.DetalleReservacion.FirstOrDefault(x => x.IdDetalleReservacion == idDetalleReservacion);
                    tDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    tDetalle.Pedido = Convert.ToString(cmbComida.Text);
                    tDetalle.Fecha = FechaRegistro;

                    Variables.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Guarde");
                    DetalleReservacion tbDetalle = new DetalleReservacion();
                    tbDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    tbDetalle.Pedido = Convert.ToString(cmbComida.Text);
                    tbDetalle.Fecha = FechaRegistro;
                    Variables.DetalleReservacion.Add(tbDetalle);
                    Variables.SaveChanges();
                }
                Limpiar();
                editar = false;
                idReservacion = 0;
                CargaDetalleDv();
                MessageBox.Show("Informacion guardada!");
                Limpiar();
            }
          

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

                try
                {
                    Int64 IdVen = Convert.ToInt64(cmbCliente.SelectedValue.ToString());
                    var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente == IdVen);
                    txtApellido.Text = tCliente.Apellido;
                }
                catch
                {

                }

            if (log == 1)
            {
              //  MessageBox.Show("Algo");
               // Limpiar();
            }
        }

        private void dvReservacion_MouseClick(object sender, MouseEventArgs e)
        {

         
        }

        private void dvRegistro_MouseClick(object sender, MouseEventArgs e)
        {
            if (log == 1)
            {
                log = 2;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
