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
       
        long idTemporal;
        int log;
        long CodigoReserva;
        DateTime FechaRegistro;
   
        MonteCarlo Variables = new MonteCarlo();
        long idReservacion = 0;
        long idDetalleReservacion = 0;
        string nombre = "";
        bool editar = false;
        bool editarDetalle = false;
       // bool ValidarComida = false;
        bool ValidarCliente = false;


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
                                where p.IdReservacion == CodigoReserva
                                select new
                                {p.IdReservacion,
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
                    MessageBox.Show("Modifico la reservación");
                //  int idR = Convert.ToInt32(.SelectedIndex.ToString()) + 1;
                long idReservaciones = Convert.ToInt64(dvRegistro.SelectedCells[0].Value);
                var tReservacion = Variables.Reservacion.FirstOrDefault(x => x.IdReservacion == idReservaciones);
                int id = Convert.ToInt32(cmbCliente.SelectedIndex.ToString()) + 1;
                var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente == id);
                tReservacion.Cliente = tCliente.Nombre;
                    tReservacion.Apellido = Convert.ToString(txtApellido.Text);
                    tReservacion.Zona = Convert.ToString(txtLugar.Text);
                    tReservacion.Fecha = Convert.ToDateTime(Fecha.Text);
                    tReservacion.Hora = Convert.ToString(txtHora.Text);

                    Variables.SaveChanges();
                }
                else
                {
               
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

                MessageBox.Show("La reservacion se realizo!");
            }
                editar = false;
                idReservacion = 0;
                CargaDv();

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
                CodigoReserva = idReservaciones;
                var tbReservacion = from p in Variables.DetalleReservacion
                                    where p.IdReservacion == idReservaciones
                                    select new
                                    {
                                        p.IdDetalleReservacion,
                                        p.Pedido,
                                        p.Cantidad

                                    };
                dvReservacion.DataSource = tbReservacion.CopyAnonymusToDataTable();
                editarDetalle = false;
                dvReservacion.ClearSelection();
                LimpiarPedido();

            }
            catch (Exception)
            {
                dvReservacion.ClearSelection();
                dvRegistro.ClearSelection();
            }
            if (log == 1)
            {
                Limpiar();
            }

            try
            {
                long idReservaciones = Convert.ToInt64(dvRegistro.SelectedCells[0].Value);
                var tReserva = Variables.Reservacion.FirstOrDefault(x => x.IdReservacion == idReservaciones);
                txtApellido.Text = tReserva.Apellido;
                txtHora.Text = tReserva.Hora;
                txtLugar.Text = tReserva.Zona;
                cmbCliente.Text = Convert.ToString(tReserva.Cliente);
                Fecha.Text = Convert.ToString(tReserva.Fecha);
                editar = true;
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
                return;
            }
            if (txtCantidad.Text != "")
            {
                if (Convert.ToInt32(txtCantidad.Text) < 1)
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0");
                    return;
                }

            }
            if (cmbComida.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Por favor seleccione el preoducto");
                return;
            }

            if (editarDetalle)
            {
                MessageBox.Show("Modifico el pedido!");
                long idPedido = Convert.ToInt64(dvReservacion.SelectedCells[0].Value);
                var tDetalles = Variables.DetalleReservacion.FirstOrDefault(x => x.IdDetalleReservacion == idPedido);
                tDetalles.Cantidad = Convert.ToInt32(txtCantidad.Text);
                tDetalles.Pedido = Convert.ToString(cmbComida.Text);
                tDetalles.Fecha = FechaRegistro;

                Variables.SaveChanges();
                dvReservacion.ClearSelection();
            }
            else
            {
                MessageBox.Show("Pedido guardado!");
                DetalleReservacion tbDetalle = new DetalleReservacion();
                if(idTemporal >0)
                {
                    tbDetalle.IdReservacion = Convert.ToInt32(idTemporal);
                }
                if(idTemporal == 0)
                {
                    tbDetalle.IdReservacion = Convert.ToInt32(CodigoReserva);
                }

                tbDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                tbDetalle.Pedido = Convert.ToString(cmbComida.Text);
                tbDetalle.Fecha = FechaRegistro;
                Variables.DetalleReservacion.Add(tbDetalle);
                Variables.SaveChanges();

            }
           
            editarDetalle = false;
            idReservacion = 0;
            CargaDetalleDv();

            LimpiarPedido();
       
        }

        private void dvReservacion_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                long idPedido = Convert.ToInt64(dvReservacion.SelectedCells[0].Value);
                var tPedido = Variables.DetalleReservacion.FirstOrDefault(x => x.IdDetalleReservacion == idPedido);
                txtCantidad.Text = Convert.ToString(tPedido.Cantidad);
                cmbComida.Text = Convert.ToString(tPedido.Pedido);
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

        private void btnLimpiarPedido_Click(object sender, EventArgs e)
        {
            dvReservacion.ClearSelection();
            LimpiarPedido();
        }
    }
}
