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
        private int contadorcomida=0;
        Finca_Monte_CarloEntities1 Variables = new Finca_Monte_CarloEntities1();
        long idVenta = 0;
        bool editar = false;
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
           // txtCliente.Text = "";
            //txtEmpleado.Text = "";
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
           
            limpiardetalle();
        }





        private Boolean Validar()
        {
            Boolean validar = true;

            if (txtIdVenta.Text == "")
            {
                MessageBox.Show("Ingrese el codigo de la venta", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdVenta.Focus();
                validar = false;
            }
            else if (txtIdFactura.Text == "")
            {
                MessageBox.Show("Ingrese el codigo de la factura", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdFactura.Focus();
                validar = false;
            }
           
            else if (Convert.ToDouble(txtPrecio.Text) == 0)
            {
                MessageBox.Show("Ingrese un precio mayor a 0", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                validar = false;
            }
            else if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                validar = false;
            }
            else if (Convert.ToInt32(txtCantidad.Text) == 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
             
                validar = false;
            }
            else
                validar = true;
            return validar;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnGenerarVenta_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiardetalle();

            //DataTable Datos = conexion.consulta(String.Format("SELECT idVenta as 'Numero De Venta',idFactura as 'Numero De Factura',idPedido as 'Pedido',precio as 'Precio',Cantidad,Total FROM DetalleDeFactura  where idVenta = {0};", venta.IdVenta));
            dvVenta.DataSource = " ";
            dvVenta.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var rowVenta = Variables.Ventas.OrderByDescending(t => t.IdVenta).FirstOrDefault();
                int idVenta = Convert.ToInt32(rowVenta.IdVenta);
                txtIdVenta.Text = Convert.ToString(idVenta+1);
            }
            catch
            {
                txtIdVenta.Text = "1";
            }

        }

        private void Generar_Venta_Load(object sender, EventArgs e)
        {
            llenarCategoria();
            var tMod = from mod in Variables.Clientes
                       select new
                       {   mod.IdCliente,
                           mod.Nombre,

                           // MessageBox.Show(Convert.ToString(tMod));
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

                           // MessageBox.Show(Convert.ToString(tMod));
                       };

            DataTable dtcomi = tcomi.CopyAnonymusToDataTable();
            cmbComidaBebida.DataSource = dtcomi;

            cmbComidaBebida.ValueMember = dtcomi.Columns[0].ColumnName;
            cmbComidaBebida.DisplayMember = dtcomi.Columns[1].ColumnName;



        }

        private void llenarCategoria()
        {
           
        }


        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(e);
        }
        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtIdVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(e);
        }

        private void txtIdPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(e);
        }

        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(e);

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.numerosConDecimales(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(e);
        }

        private void cmbComida_SelectedIndexChanged(object sender, EventArgs e)
        {

            contadorcomida = contadorcomida + 1;
            //  MessageBox.Show(Convert.ToString(Contador));
            // MessageBox.Show(cmbVenta.SelectedItem.ToString());
            if (contadorcomida > 2)
            {


                Int64 IdComidaBebida = Convert.ToInt64(cmbComidaBebida.SelectedValue.ToString());


                var tMenus = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == IdComidaBebida);
                txtPrecio.Text = Convert.ToString(tMenus.Precio);
            }

        }

        private void cmbComida_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void cmbComida_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmbComida_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            conta = conta + 1;
            //  MessageBox.Show(Convert.ToString(Contador));
            // MessageBox.Show(cmbVenta.SelectedItem.ToString());
            if (conta > 2)
            {


                Int64 IdVen = Convert.ToInt64(cmbCliente.SelectedValue.ToString());

             
                var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente == IdVen);
                txtApellido.Text = tCliente.Apellido;
            }
        }

        private void cmbImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                var rowFactura = Variables.Facturas.OrderByDescending(t => t.IdFactura).FirstOrDefault();
               if(Convert.ToString(rowFactura) != "")
                {
                    MessageBox.Show(Convert.ToString(rowFactura));
                    int idFactura = Convert.ToInt32(rowFactura.IdFactura);
                    txtIdFactura.Text = Convert.ToString(idFactura);
                }
                else
                {
                    txtIdFactura.Text = "1";
                }
               
          
        }
    }
}
