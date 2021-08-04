using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Venta
{
    public partial class Generar_Venta : Form
    {
        double imp;
        private int conta = 0;
        int CodigoVenta;
        double total = 0.0;
        long idVenta = 0;
        int log;
        private bool VentaValida = true;
        private int contadorcomida = 0;
        MonteCarlo Variables = new MonteCarlo();
        long idDetalleVenta = 0;
        string nombre = "";
        bool editar = false;
        bool ValidarComida = false;
        bool ValidarCliente = false;
        double impuesto = 0.0;
        double TotImpuesto = 0.0;
        double TotSubtotal = 0.0;
        double Subtotal = 0.0;
        DataTable dtVentas = new DataTable();

        public Generar_Venta()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            conta = 2;
            contadorcomida = 4;
            cmbCliente.SelectedIndex = -1;
            txtApellido.Text = "";
            txtIdVenta.Text = "";
            cmbComidaBebida.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            Total.Text = "";
            dvVenta.DataSource = " ";
            dvVenta.Refresh();
        }

        private void Limpiardetalle()
        {
            cmbImpuesto.SelectedValue = 0;
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }

        private void DvDetalle()
        {

            try
            {

                Int64 IdVen = Convert.ToInt64(txtIdVenta.Text);
                Int64 IdComidaBebida = Convert.ToInt64(cmbComidaBebida.SelectedValue.ToString());
                var tdetalle = from p in Variables.DetalleVenta
                               join f in Variables.Ventas on p.IdVenta equals f.IdVenta
                               where p.IdVenta == IdVen
                               select new
                               {
                                   p.IdDetalleVentas,
                                   p.Comida,
                                   p.PrecioComidaBebida,
                                   p.Cantidad,
                                   p.Subtotal,
                                   p.Impuesto,
                               };
                dvVenta.DataSource = tdetalle.CopyAnonymusToDataTable();
                dvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                foreach (DataGridViewRow row in dvVenta.Rows)
                {


                    total = total + Convert.ToDouble(row.Cells[4].Value.ToString());

                }

                Total.Text = Convert.ToString(total);
            }
            catch
            {

            }

        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {

            //   Validar();
 
            if (txtIdVenta.Text == "")
            {
                MessageBox.Show("Ingrese el codigo de la venta");
                txtIdVenta.Focus();
                return;
            }
             if (Convert.ToDouble(txtPrecio.Text) == 0)
            {
                MessageBox.Show("Ingrese un precio mayor a 0");
                txtPrecio.Focus();
                return;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad");
                txtCantidad.Focus();
                return;
            }
            else if (Convert.ToInt32(txtCantidad.Text) == 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
                txtPrecio.Focus();

                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido");
                txtApellido.Focus();

                return;
            }

            if (dvVenta.Rows.Count <= 1)
            {
                editar = false;
            }
            //  MessageBox.Show(Convert.ToString(dvVenta.Rows.Count));
            if (editar)
            {

                MessageBox.Show("Modifique");
                var tdetalles = Variables.DetalleVenta.FirstOrDefault(x => x.IdDetalleVentas == idDetalleVenta);
                tdetalles.PrecioComidaBebida = Convert.ToDouble(txtPrecio.Text);
                tdetalles.Cantidad = Convert.ToInt32(txtCantidad.Text);
                if (cmbCliente.SelectedValue.ToString() == "15%")
                {
                    impuesto = 0.15;
                }
                if (cmbCliente.SelectedValue.ToString() == "18%")
                {
                    impuesto = 0.18;
                }
                if (cmbCliente.SelectedValue.ToString() == "Exento")
                {
                    impuesto = 0;
                }
                tdetalles.Impuesto = impuesto;

                Variables.SaveChanges();


            }
            else
            {
                if (txtIdVenta.Text == "")
                {
                    MessageBox.Show("No puede ingresar un producto sin ingresar la venta");
                    btnVenta.Focus();
                    return;
                }

                MessageBox.Show("Guarde");
                DetalleVenta tbdetalles = new DetalleVenta();
                tbdetalles.Fecha = FechaActual;
                tbdetalles.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                tbdetalles.IdVenta = Convert.ToInt32(txtIdVenta.Text);
                tbdetalles.IdComidaBebida = Convert.ToInt32(cmbComidaBebida.SelectedValue.ToString());
                var MENU = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == tbdetalles.IdComidaBebida);
                tbdetalles.Comida = MENU.Nombre;
                tbdetalles.PrecioComidaBebida = Convert.ToDouble(txtPrecio.Text);
                tbdetalles.Cantidad = Convert.ToInt32(txtCantidad.Text);
                Subtotal = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                tbdetalles.Subtotal = Subtotal;
                //  MessageBox.Show(cmbImpuesto.SelectedItem.ToString());

                if (cmbImpuesto.SelectedItem.ToString() == "Exento")
                {
                    impuesto = 0;
                } else
                if (cmbImpuesto.SelectedItem.ToString() == "15%")
                {
                    impuesto = 0.15;
                } else
                {
                    impuesto = 0.18;
                }
                impuesto = impuesto * (Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text));
             
                tbdetalles.Impuesto = impuesto;
                Variables.DetalleVenta.Add(tbdetalles);
                Variables.SaveChanges();
                total = imp + Subtotal - impuesto;
                Total.Text = Convert.ToString(total);
                TotImpuesto = TotImpuesto + impuesto;
                TotSubtotal = TotSubtotal + Subtotal;
                Limpiardetalle();
            }

            //Desplegar en la tabla
            DvDetalle();
            idDetalleVenta = 0;
            // Limpiar();
            editar = false;
            ValidarCliente = false;
            cmbComidaBebida.SelectedIndex = -1;
            Limpiardetalle();

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 IdVen = Convert.ToInt64(txtIdVenta.Text);
                // MessageBox.Show("Elimino la venta", Convert.ToString(idVenta));
                if (IdVen != 0)
                {
                    Variables.Ventas.RemoveRange(Variables.Ventas.Where(x => x.IdVenta == IdVen));
                    Variables.SaveChanges();

                    Variables.DetalleVenta.RemoveRange(Variables.DetalleVenta.Where(x => x.IdVenta == IdVen));
                    Variables.SaveChanges();
                    Limpiar();
                    Limpiardetalle();
                    DvClientes();
                }
                if (editar == false)
                {
                    MessageBox.Show("Debe haber un registro seleccionado para poder borrarlo");
                }
                else
                {

                    Variables.DetalleVenta.RemoveRange(Variables.DetalleVenta.Where(x => x.IdDetalleVentas == idDetalleVenta));
                    Variables.SaveChanges();
                    //   Limpiar();
                    DvDetalle();


                }

                //  Limpiar();
                // dvCliente.ClearSelection();
                Limpiardetalle();
            }catch
            { }
        }

        private void BtnGenerarVenta_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                MessageBox.Show("No Se ha realizao ninguna venta");
            }
            else
            {
                if (txtIdVenta.Text == "")
                {
                    MessageBox.Show("No puede ingresar un producto sin ingresar la venta");
                    btnVenta.Focus();
                    return;
                }

                MessageBox.Show("Guarde la factura");
                Facturas tbfactura = new Facturas();
                //tbfactura.Fecha = FechaActual;
                tbfactura.Fecha = DateTime.Today;
                tbfactura.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                tbfactura.Subtotal = TotSubtotal;
                tbfactura.Impuesto = TotImpuesto;
                tbfactura.Total = Convert.ToInt32(Total.Text);
                var rowNomCli = Variables.Clientes.FirstOrDefault(x => x.IdCliente == tbfactura.IdCliente);
                tbfactura.NombreCliente = Convert.ToString(rowNomCli.Nombre + " " + rowNomCli.Apellido);
                tbfactura.Impuesto = impuesto;
                Variables.Facturas.Add(tbfactura);
                Variables.SaveChanges();

                Limpiardetalle();
            }


            idDetalleVenta = 0;
            // Limpiar();
            editar = false;
            ValidarCliente = false;
            cmbComidaBebida.SelectedIndex = -1;
            Limpiar();
            Limpiardetalle();

            //DataTable Datos = conexion.consulta(String.Format("SELECT idVenta as 'Numero De Venta',idFactura as 'Numero De Factura',idPedido as 'Pedido',precio as 'Precio',Cantidad,Total FROM DetalleDeFactura  where idVenta = {0};", venta.IdVenta));
            dvVenta.DataSource = " ";
            dvVenta.Refresh();

        }

        private void validad_venta()
        {
            if (cmbCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Para realizar la venta necesita un  cliente");
                cmbCliente.Focus();
                VentaValida = false;
                return;
            }
            if (txtIdVenta.Text != "")
            {
                MessageBox.Show("No puede realizar una venta encima de otra");
                cmbComidaBebida.Focus();
                return;
            }

        }
        public DateTime FechaActual
        {
            get { return DateTime.Today; ; }
            set { this.FechaActual = value; }
        }

        private void guardar()
        {
            Int64 IdNombre = Convert.ToInt64(cmbCliente.SelectedValue.ToString());
            var tMenus = Variables.Clientes.FirstOrDefault(x => x.IdCliente == IdNombre);
            // MessageBox.Show("Aqui esta el precio");


            MessageBox.Show("Guarde");
            Ventas tbventas = new Ventas();
            tbventas.Nombre = Convert.ToString(tMenus.Nombre);
            tbventas.Apellido = txtApellido.Text;
            tbventas.Fecha = FechaActual;
            tbventas.IdCliente = Convert.ToInt32(cmbCliente.SelectedIndex.ToString() + 1);
            Variables.Ventas.Add(tbventas);
            Variables.SaveChanges();
            CodigoVenta = tbventas.IdVenta;
            txtIdVenta.Text = Convert.ToString(CodigoVenta);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "")
            {
                log = 2;
            }
            // dvCliente.ClearSelection();
            validad_venta();
                int idVenta = Convert.ToInt32(CodigoVenta);
            guardar();
            //Area de Clientes
            var tClientes = from p in Variables.Ventas
                            where p.Fecha == FechaActual
                            select new
                            {
                                p.IdVenta,
                                p.Nombre,
                                p.Apellido,
                            //    p.Pagado

                            };

            dvCliente.DataSource = tClientes.CopyAnonymusToDataTable();
            dvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Generar_Venta_Load(object sender, EventArgs e)
        {

            dvCliente.ClearSelection();

            dvVenta.ClearSelection();
            cmbImpuesto.SelectedIndex = 0;
            var tMod = from mod in Variables.Clientes
                       select new
                       { mod.IdCliente,
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
            cmbComidaBebida.DataSource = dtcomi;
            cmbComidaBebida.ValueMember = dtcomi.Columns[0].ColumnName;
            cmbComidaBebida.DisplayMember = dtcomi.Columns[1].ColumnName;

            DvClientes();
            // idCompras = 0;

            editar = false;
            Limpiar();
            log = 1;

        }
        private void DvClientes()
{
            //Area de Clientes
            var tClientes = from p in Variables.Ventas
                            where p.Fecha == FechaActual
                            select new
                            {
                                p.IdVenta,
                                p.Nombre,
                                p.Apellido,
                              //  p.Pagado

                            };


            dvCliente.DataSource = tClientes.CopyAnonymusToDataTable();
            dvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }     
        private void cmbComida_SelectedIndexChanged(object sender, EventArgs e)
        {
        
     
                try
                {
                    if (cmbComidaBebida.SelectedIndex != -1)
                    {
                        Int64 IdComidaBebida = Convert.ToInt64(cmbComidaBebida.SelectedValue.ToString());
                        var tMenus = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == IdComidaBebida);
                        // MessageBox.Show("Aqui esta el precio");
                        txtPrecio.Text = Convert.ToString(tMenus.Precio);
                    }

                }
                catch { }
                
            
        }   
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
          
          
            conta ++;
             if(conta == 4)
              {
                ValidarCliente = true;
              }
            if (ValidarCliente==true)
            {
                try
                {
                    Int64 IdVen = Convert.ToInt64(cmbCliente.SelectedValue.ToString());
                    var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente == IdVen);
                    txtApellido.Text = tCliente.Apellido;
                }
                catch { }
      
            }
               
            
        }


        private void dvVenta_SelectionChanged(object sender, EventArgs e)
        {
            Limpiardetalle();
                try
                {
                    idDetalleVenta = Convert.ToInt64(dvVenta.SelectedCells[0].Value);
                    var tDetalle = Variables.DetalleVenta.FirstOrDefault(x => x.IdDetalleVentas == idDetalleVenta);
                var tcomida = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == tDetalle.IdComidaBebida);
                cmbComidaBebida.Text = Convert.ToString(tcomida.Nombre);
                    txtPrecio.Text = Convert.ToString(tDetalle.PrecioComidaBebida);
                    txtCantidad.Text = Convert.ToString(tDetalle.Cantidad);
                    editar = true;
                }
                catch (Exception)
                {

                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dvCliente_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                long idCliente = Convert.ToInt64(dvCliente.SelectedCells[0].Value);
                if(txtApellido.Text != "")
                {
                    idCliente = 0;
                }
                var tClien = Variables.Ventas.FirstOrDefault(x => x.IdVenta == idCliente);
                cmbCliente.Text = tClien.Nombre;
                txtApellido.Text = Convert.ToString(tClien.Apellido);
                txtIdVenta.Text = Convert.ToString(tClien.IdVenta);
       
                editar = true;
                    Int64 IdVen = Convert.ToInt32(txtIdVenta.Text);              
                var tdetalle = from p in Variables.DetalleVenta
                                   where p.IdVenta == IdVen
                                   select new
                                   {
                                       p.IdDetalleVentas,
                                       p.Comida,
                                       p.PrecioComidaBebida,
                                       p.Cantidad,
                                       p.Subtotal,
                                       p.Impuesto,
                                   };
                    dvVenta.DataSource = tdetalle.CopyAnonymusToDataTable();
                    dvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                foreach (DataGridViewRow row in dvVenta.Rows)
                {

                    total = total + Convert.ToDouble(row.Cells[4].Value.ToString());
                    Total.Text = Convert.ToString(total);
                    imp = total;
                }
            

            }
            catch (Exception)
            {
            }
            if (log == 1)
            {
                Limpiar();
                DvDetalle();
            }
          
        }
        private void dvCliente_MouseMove(object sender, MouseEventArgs e)
        {
            if (log == 1)
            {
                log = 2;
            }
        }

   

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            dvVenta.ClearSelection();
            dvCliente.ClearSelection();
            editar = false;
            Limpiardetalle();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Limpiardetalle();
            DvDetalle();
        }
    }
}
