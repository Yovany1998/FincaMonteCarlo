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
        int log;
        int Validar = 0;
        MonteCarlo Variables = new MonteCarlo();
        long idDetalleVenta = 0;
        string nombre = "";
        bool editar = false;
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
            cmbComidaBebida.SelectedIndex = -1;
            txtCantidad.Text = "";
        }

        private void DvDetalle()
        {

            try
            {

                Int64 IdVen = Convert.ToInt64(txtIdVenta.Text);
     
                Int64 IdComidaBebida = Convert.ToInt64(cmbComidaBebida.SelectedValue.ToString());
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
                }

                Total.Text = Convert.ToString(total);       
            }
            catch
            {

            }

        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        { 
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
            if (editar)
            {

                MessageBox.Show("Detalle Modificado!");
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

                DetalleVenta tbdetalles = new DetalleVenta
                {
                    Fecha = FechaActual,
                    IdCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString()),
                    IdVenta = Convert.ToInt32(txtIdVenta.Text),
                    IdComidaBebida = Convert.ToInt32(cmbComidaBebida.SelectedValue.ToString())
                };
                var MENU = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == tbdetalles.IdComidaBebida);
                tbdetalles.Comida = MENU.Nombre;
                tbdetalles.PrecioComidaBebida = Convert.ToDouble(txtPrecio.Text);
                tbdetalles.Cantidad = Convert.ToInt32(txtCantidad.Text);
                Subtotal = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                tbdetalles.Subtotal = Subtotal;

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
      
            ValidarCliente = false;
    

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
            Limpiardetalle();
            editar = false;
            dvVenta.ClearSelection();


        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 IdVen = Convert.ToInt64(txtIdVenta.Text);
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
                    DvDetalle();


                }
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
                try
                {
                    Facturas tbfactura = new Facturas
                    {
                        Fecha = DateTime.Today,
                        IdVenta = Convert.ToInt32(txtIdVenta.Text),
                        IdCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString()),
                        Subtotal = TotSubtotal,
                        Impuesto = TotImpuesto,
                        Total = Convert.ToInt32(Total.Text)
                    };
                    var rowNomCli = Variables.Clientes.FirstOrDefault(x => x.IdCliente == tbfactura.IdCliente);
                    tbfactura.NombreCliente = Convert.ToString(rowNomCli.Nombre + " " + rowNomCli.Apellido);
                    tbfactura.Impuesto = impuesto;
 
                    Variables.Facturas.Add(tbfactura);
                    Variables.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Esta Venta Ya se genero!");
                    Validar = 1;
                }
                if(Validar != 1)
                {
                    MessageBox.Show("Se genero la factura con la venta");
                }


                Limpiardetalle();
            }
            idDetalleVenta = 0;
            editar = false;
            ValidarCliente = false;
            cmbComidaBebida.SelectedIndex = -1;
            Limpiar();
            Limpiardetalle();
            dvVenta.DataSource = " ";
            dvVenta.Refresh();

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
            Ventas tbventas = new Ventas
            {
                Nombre = Convert.ToString(tMenus.Nombre),
                Apellido = txtApellido.Text,
                Fecha = FechaActual,
                IdCliente = Convert.ToInt32(cmbCliente.SelectedIndex.ToString() + 1)
            };
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
            if (cmbCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Para realizar la venta necesita un  cliente");
                cmbCliente.Focus();
                return;
            }
            if (txtIdVenta.Text != "")
            {
                MessageBox.Show("No puede realizar una venta encima de otra");
                cmbComidaBebida.Focus();
                return;
            }
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
            total = 0;
            try
            {
                Limpiar();
                DvDetalle();
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
                //Detalle de la venta
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
                Limpiardetalle();
                editar = false;
                dvVenta.ClearSelection();
            
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
            editar = false;
            Limpiardetalle();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Limpiardetalle();
            DvDetalle();
        }

        private void dvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
