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
        private int conta = 0;
        double total = 0.0;
        long idVenta = 0;
        private bool VentaValida = true;
        private int contadorcomida=0;
        Finca_Monte_CarloEntities1 Variables = new Finca_Monte_CarloEntities1();
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
            this.Hide();
            Menu_Venta ventana = new Menu_Venta();
            ventana.Show();
        }

        private void limpiar()
        {
            conta = 2;
            contadorcomida = 4;
            cmbCliente.SelectedIndex = -1;
            txtApellido.Text = "";
            txtIdVenta.Text = "";
            txtIdFactura.Text = "";
            cmbComidaBebida.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            Total.Text = "";
            dvVenta.DataSource = " ";
            dvVenta.Refresh();
        }

        private void limpiardetalle()
        {
            cmbImpuesto.SelectedValue = 0;
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
           
            Validar();
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
               if(txtIdVenta.Text == "")
                {
                    MessageBox.Show("No puede ingresar un porducto sin ingresar la venta");
                    btnVenta.Focus();
                    return;
                }

                MessageBox.Show("Guarde");
                DetalleVenta tbdetalles = new DetalleVenta();
                tbdetalles.Fecha = FechaActual;
                tbdetalles.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                tbdetalles.IdVenta = Convert.ToInt32(txtIdVenta.Text);
                tbdetalles.IdFactura = Convert.ToInt32(txtIdFactura.Text);
                tbdetalles.IdComidaBebida = Convert.ToInt32(cmbComidaBebida.SelectedValue.ToString());
                tbdetalles.PrecioComidaBebida = Convert.ToDouble(txtPrecio.Text);
                tbdetalles.Cantidad = Convert.ToInt32(txtCantidad.Text);
                Subtotal  = Convert.ToInt32(txtCantidad.Text)*Convert.ToDouble(txtPrecio.Text);
                tbdetalles.Subtotal = Subtotal;
                //  MessageBox.Show(cmbImpuesto.SelectedItem.ToString());

                if (cmbImpuesto.SelectedItem.ToString() == "Exento")
                {
                    impuesto = 0;
                }else
                if (cmbImpuesto.SelectedItem.ToString() == "15%")
                {
                    impuesto = 0.15;
                }else
                   {
                    impuesto = 0.18;
                }
                impuesto = impuesto * (Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text));

                tbdetalles.Impuesto = impuesto;
                Variables.DetalleVenta.Add(tbdetalles);
                Variables.SaveChanges();
                total = total + Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text)+ impuesto;
                Total.Text = Convert.ToString(total);
                TotImpuesto = TotImpuesto + impuesto;
                TotSubtotal = TotSubtotal + Subtotal;
                limpiardetalle();
            }

            //Desplegar en la tabla
            Int64 IdVen = Convert.ToInt64(txtIdVenta.Text);
            Int64 IdComidaBebida = Convert.ToInt64(cmbComidaBebida.SelectedValue.ToString());
            var tdetalle = from p in Variables.DetalleVenta
                           join t in Variables.Menu on p.IdComidaBebida equals t.IdComidaBebida
                           join f in Variables.Ventas on p.IdVenta equals f.IdVenta
                            where p.IdVenta == IdVen
                           select new
                                {  p.IdDetalleVentas,
                                    t.Nombre,
                                    p.PrecioComidaBebida,
                                    p.Cantidad,
                                    p.Subtotal,
                                    p.Impuesto,
                                };
            dvVenta.DataSource = tdetalle.CopyAnonymusToDataTable();
            dvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idDetalleVenta = 0;
           // limpiar();
            editar = false;
            ValidarCliente = false;
            cmbComidaBebida.SelectedIndex = -1;
           
        }
        private void Validar()
        {
           

            if (txtIdVenta.Text == "")
            {
                MessageBox.Show("Ingrese el codigo de la venta");
                txtIdVenta.Focus();
                return;
            }
            else if (txtIdFactura.Text == "")
            {
                MessageBox.Show("Ingrese el codigo de la factura");
                txtIdFactura.Focus();
                return;
            }
           
            else if (Convert.ToDouble(txtPrecio.Text) == 0)
            {
                MessageBox.Show("Ingrese un precio mayor a 0");
                txtPrecio.Focus();
                return;
            }
            else if (txtCantidad.Text == "")
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
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido");
                txtApellido.Focus();

                return;
            }


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiardetalle();
        }

        private void BtnGenerarVenta_Click(object sender, EventArgs e)
        {


            Validar();
            if (editar)
            {
                MessageBox.Show("No deberia entrar aqui");
            }
            else
            {
                if (txtIdVenta.Text == "")
                {
                    MessageBox.Show("No puede ingresar un porducto sin ingresar la venta");
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
                tbfactura.NombreCliente = Convert.ToString(rowNomCli.Nombre);
                tbfactura.Impuesto = impuesto;
                Variables.Facturas.Add(tbfactura);
                Variables.SaveChanges();
          
                limpiardetalle();
            }

           
            idDetalleVenta = 0;
            // limpiar();
            editar = false;
            ValidarCliente = false;
            cmbComidaBebida.SelectedIndex = -1;
            limpiar();
            limpiardetalle();

            //DataTable Datos = conexion.consulta(String.Format("SELECT idVenta as 'Numero De Venta',idFactura as 'Numero De Factura',idPedido as 'Pedido',precio as 'Precio',Cantidad,Total FROM DetalleDeFactura  where idVenta = {0};", venta.IdVenta));
            dvVenta.DataSource = " ";
            dvVenta.Refresh();

        }

        private void validad_venta()
        {
            if(cmbCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Para realizar la venta necesita un  cliente");
                cmbCliente.Focus();
                VentaValida = false;
                return;
            }
            if(txtIdVenta.Text != "")
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
            Ventas tbventas = new Ventas();
            tbventas.IdFactura =Convert.ToInt32(txtIdFactura.Text);
            tbventas.Fecha = FechaActual;
            tbventas.IdCliente = Convert.ToInt32(cmbCliente.SelectedIndex.ToString());
            Variables.Ventas.Add(tbventas);   
            Variables.SaveChanges();
          //  idVenta = tbventas.IdVenta;
        }

    
        
        private void button1_Click(object sender, EventArgs e)
        {
                validad_venta();
            var rowVenta = Variables.Ventas.OrderByDescending(t => t.IdVenta).FirstOrDefault();
            var rowFactura = Variables.Facturas.OrderByDescending(a => a.IdFactura).FirstOrDefault();
            //  MessageBox.Show(Convert.ToString(rowVenta));
            if (rowVenta != null)
            {

                int idVenta = Convert.ToInt32(rowVenta.IdVenta);
                txtIdVenta.Text = Convert.ToString(idVenta + 1);
            }
            else
            {
                txtIdVenta.Text = "1";
               
            }
            if (rowFactura != null)
                {
                    int idFactura = Convert.ToInt32(rowFactura.IdFactura);
                    txtIdFactura.Text = Convert.ToString(idFactura + 1);
                }
                else
                {
                    txtIdFactura.Text = "1";
                }
                    
                    guardar();
                
              
        }

        private void Generar_Venta_Load(object sender, EventArgs e)
        {
            cmbImpuesto.SelectedIndex = 0;
            var tMod = from mod in Variables.Clientes
                       select new
                       {   mod.IdCliente,
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
            limpiar();
        
        }
        private void cmbComida_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            contadorcomida = contadorcomida + 1;
            if (contadorcomida >5)
            {

                ValidarComida = true;
            }
           // MessageBox.Show(Convert.ToString(contadorcomida));
            if (ValidarComida)
            {
                if (cmbComidaBebida.SelectedIndex != -1){
                    Int64 IdComidaBebida = Convert.ToInt64(cmbComidaBebida.SelectedValue.ToString());
                    var tMenus = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == IdComidaBebida);
                    // MessageBox.Show("Aqui esta el precio");
                    txtPrecio.Text = Convert.ToString(tMenus.Precio);
                }
             
            }
        }   
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            conta = conta + 1;
             if(conta == 4)
              {
                ValidarCliente = true;
              }
            if (ValidarCliente==true)
            {
               
                Int64 IdVen = Convert.ToInt64(cmbCliente.SelectedValue.ToString());
                var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente == IdVen);
                txtApellido.Text = tCliente.Apellido;
            }
               
            
        }
        private void cmbImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        { 
             //   var rowFactura = Variables.Facturas.OrderByDescending(t => t.IdFactura).FirstOrDefault();
              // if(Convert.ToString(rowFactura) != "")
               // {
                 //   MessageBox.Show(Convert.ToString(rowFactura));
                   // int idFactura = Convert.ToInt32(rowFactura.IdFactura);
                    //txtIdFactura.Text = Convert.ToString(idFactura);
               // }
               // else
               // {
                 //   txtIdFactura.Text = "1";
               // }              
        }

        private void dvVenta_SelectionChanged(object sender, EventArgs e)
        { limpiardetalle();
            if (dvVenta.RowCount > 1)
            {
                //  MessageBox.Show("Entre");
                //  int contado = 0;
                // contado = contado + 1;

                try
                {
                    //  MessageBox.Show(Convert.ToString(contado));
                    idDetalleVenta = Convert.ToInt64(dvVenta.SelectedCells[0].Value);
                    MessageBox.Show(Convert.ToString(idDetalleVenta));
                    var tDetalle = Variables.DetalleVenta.FirstOrDefault(x => x.IdDetalleVentas == idDetalleVenta);

                    cmbComidaBebida.Text = Convert.ToString(tDetalle.IdComidaBebida);
                    txtPrecio.Text = Convert.ToString(tDetalle.PrecioComidaBebida);
                    txtCantidad.Text = Convert.ToString(tDetalle.Cantidad);
                    // txtSubtotal.Text= Convert.ToString(tDetalle.Subtotal);
                   
                    editar = true;

                }
                catch (Exception)
                {

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
