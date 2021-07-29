using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Salidas
{
    public partial class Ingresar_Compras : Form
    {
        MonteCarlo Variables = new MonteCarlo();
        long idCompras = 0;
        bool editar = false;
        int contador = 0;
        Double Subto;

        public Ingresar_Compras()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtDetalle.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtCantidad.Text = "";
            idCompras = 0;
            editar = false;

        }

        private void Ingresar_Compras_Load(object sender, EventArgs e)
        {
            DateTime Fechas = Convert.ToDateTime(FechaActual.ToString("yyyy/MM/dd 00:00:00"));
            var tCompras = from p in Variables.Compras
                           where p.Fecha == Fechas
                           select new
                                {
                                    p.IdCompra,
                                    p.Fecha,
                                    p.Producto,
                                    p.Precio,
                                    p.Cantidad,
                                    p.Detalle,
                                    p.Subtotal
                                };

            dvCompra.DataSource = tCompras.CopyAnonymusToDataTable();
            dvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idCompras = 0;
            Limpiar();
            editar = false;
        }
        public DateTime FechaActual
        {
            get { return DateTime.Today; ; }
            set { this.FechaActual = value; }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese el producto");
                return;
            }
            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el precio");
                return;
            }
            if (txtDetalle.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el detalle de la compra");
                return;
            }

            Subto = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);

            if (editar)
            {
                MessageBox.Show("Modifique");
                var tCompra = Variables.Compras.FirstOrDefault(x => x.IdCompra == idCompras);
                tCompra.Producto = txtProducto.Text;
                tCompra.Precio = Convert.ToDouble(txtPrecio.Text);
                tCompra.Detalle = txtDetalle.Text;
                tCompra.Cantidad =Convert.ToInt32(txtCantidad.Text);
                tCompra.Subtotal = Subto;
               // tCompra.Fecha = FechaActual;
                Variables.SaveChanges();
            }
            else
            {
                MessageBox.Show("Guarde");
                Compras tbCompra = new Compras();
                tbCompra.Producto = txtProducto.Text;
                tbCompra.Precio = Convert.ToDouble(txtPrecio.Text);
                tbCompra.Detalle = txtDetalle.Text;
                tbCompra.Cantidad = Convert.ToInt32(txtCantidad.Text);
                tbCompra.Fecha = FechaActual;
                tbCompra.Subtotal = Subto;
                Variables.Compras.Add(tbCompra);
                Variables.SaveChanges();
            }

            Limpiar();
            editar = false;
            idCompras = 0;

            var tCompras = from p in Variables.Compras
                           select new
                           {
                               p.IdCompra,
                               p.Fecha,
                               p.Producto,
                               p.Precio,
                               p.Cantidad,
                               p.Detalle,
                               p.Subtotal
                             
                           };

            dvCompra.DataSource = tCompras.CopyAnonymusToDataTable();

            MessageBox.Show("Informacion guardada!");
            Limpiar();


        }
    }
    
}
