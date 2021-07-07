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
        private bool VentaValida = true;
        private int contadorcomida=0;
        Finca_Monte_CarloEntities1 Variables = new Finca_Monte_CarloEntities1();
        long idDetalleVenta = 0;
        bool editar = false;
        bool ValidarComida = false;
        bool ValidarCliente = false;
        DataTable dtVentas = new DataTable();


        // private Ventas venta;
        //private Validar validacion;
        public Generar_Venta()
        {
            InitializeComponent();
          //  venta = new Ventas();
            //validacion = new Validar();
         
            
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
        }

        private void limpiardetalle()
        {
            //txtIdPedido.Text = "";
            cmbComidaBebida.SelectedIndex = -1;
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
                tdetalles.NombreComidaBebida = cmbComidaBebida.SelectedItem.ToString();
                tdetalles.PrecioComidaBebida = Convert.ToDouble(txtPrecio.Text);
                tdetalles.Cantidad = Convert.ToInt32(txtCantidad.Text);
                tdetalles.Impuesto = Convert.ToDouble(cmbImpuesto.SelectedItem.ToString());

                Variables.SaveChanges();
            }
            else
            {
                MessageBox.Show("Guarde");
                DetalleVenta tbdetalles = new DetalleVenta();
                tbdetalles.NombreComidaBebida = cmbComidaBebida.SelectedItem.ToString();
                tbdetalles.PrecioComidaBebida = Convert.ToDouble(txtPrecio.Text);
                tbdetalles.Cantidad = Convert.ToInt32(txtCantidad.Text);
                tbdetalles.Impuesto = Convert.ToDouble(cmbImpuesto.SelectedItem.ToString());
                Variables.DetalleVenta.Add(tbdetalles);
                Variables.SaveChanges();
            }

            limpiar();
            editar = false;
            idDetalleVenta = 0;


            Int64 IdVen = Convert.ToInt64(cmbCliente.SelectedValue.ToString());

            var tdetalle  = from p in Variables.DetalleVenta
                            join t in Variables.Ventas on p.IdVenta equals t.IdVenta
                            where p.IdVenta == IdVen
                            select new
                           {
                               p.NombreComidaBebida,
                               p.PrecioComidaBebida,
                               p.Cantidad,
                               p.Subtotal,
                               p.Impuesto,
                              
                           };
            dvVenta.DataSource = tdetalle.CopyAnonymusToDataTable();
            dvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idDetalleVenta = 0;
            limpiar();
            editar = false;
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
        }

        private void BtnGenerarVenta_Click(object sender, EventArgs e)
        {
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
       
        }
        public DateTime FechaActual
        {
            get { return DateTime.Now; }
            set { this.FechaActual = value; }
        }

        private void guardar()
        {
            //Aqui guardo
            MessageBox.Show("Guarde la venta");
            Ventas tbventas = new Ventas();
            MessageBox.Show(txtIdFactura.Text);
            tbventas.IdFactura =Convert.ToInt32(txtIdFactura.Text);
            tbventas.Fecha = FechaActual;
            tbventas.IdCliente = Convert.ToInt32(cmbCliente.SelectedIndex.ToString());
            //  tbventas.Pagado = ;
            MessageBox.Show(Convert.ToString(tbventas));
     
            Variables.Ventas.Add(tbventas);
            Variables.SaveChanges();

        }

    
        
        private void button1_Click(object sender, EventArgs e)
        {
         //   try
           // {
                validad_venta();
            var rowVenta = Variables.Ventas.OrderByDescending(t => t.IdVenta).FirstOrDefault();
            var rowFactura = Variables.Facturas.OrderByDescending(a => a.IdFactura).FirstOrDefault();
                MessageBox.Show(Convert.ToString(rowVenta));
                if (rowVenta != null)
                {
                    
                    int idVenta = Convert.ToInt32(rowVenta.IdVenta);
                    txtIdVenta.Text = Convert.ToString(idVenta + 1);
                if(rowFactura != null)
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
                else
                {
                    txtIdVenta.Text = "1";
                    guardar();
                }
               

          //  }
           // catch
            //{
              //  if (VentaValida == true)
               // {
                 // validad_venta();
                  //  txtIdVenta.Text = "1";
                //}
              
           // }

            //Area de insertar la venta

        }

        private void Generar_Venta_Load(object sender, EventArgs e)
        {
            var tMod = from mod in Variables.Clientes
                       select new
                       {   mod.IdCliente,
                           mod.Nombre,
                       };

            DataTable dtMod = tMod.CopyAnonymusToDataTable();
            cmbCliente.DataSource = dtMod;
            cmbCliente.ValueMember = dtMod.Columns[0].ColumnName;
            cmbCliente.DisplayMember = dtMod.Columns[1].ColumnName;
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
                Int64 IdComidaBebida = Convert.ToInt64(cmbComidaBebida.SelectedValue.ToString());
                var tMenus = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == IdComidaBebida);
               // MessageBox.Show("Aqui esta el precio");
                txtPrecio.Text = Convert.ToString(tMenus.Precio);
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
    }
}
