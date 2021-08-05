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
        long idTemporal;
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
            txtApellido.Text = "";
            txtHora.Text = "";
            txtLugar.Text = "";
            cmbCliente.SelectedIndex = cmbCliente.SelectedIndex = cmbCliente.SelectedIndex = -1;
            dvRegistro.ClearSelection();
            //  dvRegistro.ClearSelection();
            dvReservacion.ClearSelection();
        }
        private void LimpiarPedido()
        {
            cmbComida.SelectedIndex = cmbComida.SelectedIndex = cmbComida.SelectedIndex = -1;
            txtCantidad.Text = "";

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
            LimpiarPedido();
            Limpiar();
            ValidarCliente = false;
            dvRegistro.ClearSelection();
            dvReservacion.ClearSelection();
            idDetalleReservacion = 0;
            idReservacion = 0;
            editar = false;
            editarDetalle = false;
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Necesita ingresar una reservacion antes de ingresar los productos para ella");
                return;
            }
            if (txtHora.Text == "")
            {
                MessageBox.Show("Por favor ingrese la hora a la que se reservara");
            }
            if (cmbCliente.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Por favor seleccione un cliente");
                return;
            }

            log = 2;
            if (editar)
                {
                    MessageBox.Show("Modifique");
                    var tReservacion = Variables.Reservacion.FirstOrDefault(x => x.IdReservacion == idReservacion);
                var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente == Convert.ToInt32(cmbCliente.SelectedItem.ToString()));
                tReservacion.Cliente = tCliente.Nombre;
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
                int id = Convert.ToInt32(cmbCliente.SelectedIndex.ToString()) + 1;
                var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente ==id);
                tbReservacion.Cliente = tCliente.Nombre;
                tbReservacion.Apellido = Convert.ToString(txtApellido.Text);
                    tbReservacion.Zona = Convert.ToString(txtLugar.Text);
                    tbReservacion.Fecha = Convert.ToDateTime(Fecha.Text);
                    FechaRegistro = Convert.ToDateTime(Fecha.Text);
                    tbReservacion.Hora = Convert.ToString(txtHora.Text);
                    Variables.Reservacion.Add(tbReservacion);
                    Variables.SaveChanges();

                    idTemporal = tbReservacion.IdReservacion;
                }
                editar = false;
                idReservacion = 0;
                CargaDv();
    
                MessageBox.Show("La reservacion se realizo!");
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   MessageBox.Show(cmbCliente.SelectedIndex.ToString());
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

            if (log == 1)
            {
                log = 2;
            }

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
            LimpiarPedido();
            dvRegistro.ClearSelection();
            dvReservacion.ClearSelection();
            editar = false;
            editarDetalle = false;

        }

        private void dvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            try

            {
               
                long  idReservaciones = Convert.ToInt64(dvRegistro.SelectedCells[0].Value);
                var tbReservacion = from p in Variables.DetalleReservacion
                                    where p.IdReservacion == idReservaciones
                                    select new
                                    {
                                        p.IdDetalleReservacion,
                                        p.Pedido,
                                        p.Cantidad

                                    };
                dvReservacion.DataSource = tbReservacion.CopyAnonymusToDataTable();
                editarDetalle = true;
            }
            catch (Exception)
            {
               
            }
            if (log == 1)
            {
                Limpiar();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtApellido.Text == "")
            {
                MessageBox.Show("Necesita ingresar una reservacion antes de ingresar los productos para ella");
                return;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Necesita ingresar una cantidad");
            }
            if (cmbComida.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Por favor seleccione el preoducto");
                return;
            }
            if (Convert.ToInt32(txtCantidad.Text) <=0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0");
            }
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
                tbDetalle.IdReservacion = Convert.ToInt32(idTemporal);
                tbDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                tbDetalle.Pedido = Convert.ToString(cmbComida.Text);
                tbDetalle.Fecha = FechaRegistro;
                Variables.DetalleReservacion.Add(tbDetalle);
                Variables.SaveChanges();
            }
           
            editarDetalle = false;
            idReservacion = 0;
            CargaDetalleDv();
            MessageBox.Show("Pedido guardado!");
            LimpiarPedido();
       
        }
    }
}
