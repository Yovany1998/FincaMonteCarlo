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

        private int contador;

        Conexion conexion;
        private Ventas venta;
        //private Validar validacion;
        public Generar_Venta()
        {
            InitializeComponent();
            venta = new Ventas();
            //validacion = new Validar();
            conexion = new Conexion();
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Venta ventana = new Menu_Venta();
            ventana.Show();
        }

        private void limpiar()
        {
            txtCliente.Text = "";
            txtEmpleado.Text = "";
            txtIdVenta.Text = "";
            txtIdFactura.Text = "";
            cmbComida.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            Total.Text = "";
        }

        private void limpiardetalle()
        {
            txtIdPedido.Text = "";
            cmbComida.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                contador = 1;
                double subventa;
                subventa = (Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCantidad.Text));


                venta.IdVenta = Convert.ToInt32(txtIdVenta.Text);
                venta.IdFactura = Convert.ToInt32(txtIdFactura.Text);
                //venta.IdComida= Convert.ToInt32(txtIdPedido.Text);
                venta.IdComida = Convert.ToInt32(cmbComida.SelectedValue.ToString());

                venta.Precio = Convert.ToDouble(txtPrecio.Text);
                venta.Cantidades = Convert.ToInt32(txtCantidad.Text);
                venta.Total = Convert.ToDouble(subventa);

                if (venta.Insertar())
                {
                    MessageBox.Show("Registro guardado correctamente", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    venta.IdVenta = Convert.ToInt32(txtIdVenta.Text);
                    Total.Text = Convert.ToString(conexion.consulta(string.Format("SELECT SUM(Total) from DetalleDeFactura where idVenta = {0}", venta.IdVenta)).Rows[0][0].ToString());
                    DataTable Datos = conexion.consulta(String.Format("SELECT idVenta as 'Numero De Venta',idFactura as 'Numero De Factura',idComida as 'Comida',precio as 'Precio',Cantidad,Total FROM DetalleDeFactura  where idVenta = {0};", venta.IdVenta));
                    dgvVenta.DataSource = Datos;
                    dgvVenta.Refresh();
                }
                else
                {
                    MessageBox.Show(string.Format("Error\n{0}", venta.Error.ToString()), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se cancelo el ingreso");
            }
            limpiardetalle();
        }


        private Boolean ValidarVenta()
        {
       
           
            Boolean validarVenta = true;
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Ingrese un cliente", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                validarVenta = false;
            }
            else if (txtEmpleado.Text == "")
            {
                MessageBox.Show("Ingrese un empleado", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpleado.Focus();
                validarVenta = false;
            }
            else
                validarVenta = true;
            return validarVenta;


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
            /*else if (txtIdPedido.Text == "")
            {
                MessageBox.Show("Ingrese el codigo del pedido", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdPedido.Focus();
                validar = false;
            }*/
            else if (cmbComida.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto", "Comida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbComida.Focus();
                validar = false;
            }
            
            else if (txtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese el precio del producto", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
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
                contador = 1;
                validar = false;
            }
            else
                validar = true;
            return validar;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (venta.Eliminar() == true)
            {
                MessageBox.Show("La venta ha sido cancelada", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                venta.IdVenta = Convert.ToInt32(txtIdVenta.Text);
                limpiar();
                contador = 2;
                limpiardetalle();

                DataTable Datos = conexion.consulta(String.Format("SELECT idVenta as 'Numero De Venta',idFactura as 'Numero De Factura',idComida as 'Comida',precio as 'Precio',Cantidad,Total FROM DetalleDeFactura  where idFactura = {0};", venta.IdVenta));
                dgvVenta.DataSource = Datos;
                dgvVenta.Refresh();
            }
        }

        private void BtnGenerarVenta_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiardetalle();

            //DataTable Datos = conexion.consulta(String.Format("SELECT idVenta as 'Numero De Venta',idFactura as 'Numero De Factura',idPedido as 'Pedido',precio as 'Precio',Cantidad,Total FROM DetalleDeFactura  where idVenta = {0};", venta.IdVenta));
            dgvVenta.DataSource = " ";
            dgvVenta.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarVenta() == true)
            {
                venta.IdCliente = (Convert.ToString(txtCliente.Text));
                venta.IdEmpleado = (Convert.ToString(txtEmpleado.Text));
                venta.Fecha = DateTime.Today;



                if (venta.Venta())
                {
                    txtIdVenta.Text = Convert.ToString(venta.IdVenta);
                    txtIdFactura.Text = Convert.ToString(venta.IdFactura);

                    MessageBox.Show("Registro guardado correctamente ", "venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format("Error\n{0}", venta.Error.ToString()), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            else
            {
                MessageBox.Show("Se cancelo la edición");
            }

        }

        private void Generar_Venta_Load(object sender, EventArgs e)
        {
            llenarCategoria();
        }

        private void llenarCategoria()
        {
            DataTable comida = new DataTable();
            Conexion nuevo = new Conexion();
            comida = nuevo.consulta(string.Format("SELECT * FROM ventas_comedor.comida"));
            cmbComida.DataSource = null;
            cmbComida.Items.Clear();
            cmbComida.ValueMember = comida.Columns["idComida"].ColumnName;
            cmbComida.DisplayMember = comida.Columns["idComida"].ColumnName;
            cmbComida.DataSource = comida;
            cmbComida.SelectedIndex = -1;
            cmbComida.Text = "Selecciona una opcion";
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
            contador = contador + 1;


            if (contador>2)
            {
                // string ud;
                //ud = cmbComida.Text;
                //txtPrecio.Text = cmbComida.Text;
                // txtPrecio.Text = conexion.consulta(string.Format("SELECT precio FROM ventas_comedor.comida where  {0};", ud)).Rows[0][0].ToString();
      
             
                txtIdPedido.Text = (Convert.ToString(conexion.consulta(string.Format("SELECT comida from comida where idComida = {0};", cmbComida.Text)).Rows[0][0].ToString()));
                txtPrecio.Text = Convert.ToString(conexion.consulta(string.Format("SELECT precio from comida where idComida = {0};", cmbComida.Text)).Rows[0][0].ToString());
          

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
    }
}
