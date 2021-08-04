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
        Double Subto;
        int log;
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
            dvCompra.ClearSelection();

        }

        private void Ingresar_Compras_Load(object sender, EventArgs e)
        {
            log = 1;
            DateTime Fechas = Convert.ToDateTime(FechaActual.ToString("yyyy/MM/dd 00:00:00"));
            var tCompras = from p in Variables.Compras
                           where p.Fecha == Fechas
                           select new
                                {
                               p.IdCompra,
                               p.Producto,
                               p.Precio,
                               p.Cantidad,
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

            CargaDv();
            MessageBox.Show("Informacion guardada!");
            Limpiar();


        }
        private void CargaDv()
        {

            DateTime Fechas = Convert.ToDateTime(FechaActual.ToString("yyyy/MM/dd 00:00:00"));
            var tCompras = from p in Variables.Compras
                           where p.Fecha == Fechas
                           select new
                           {
                               p.IdCompra,
                               p.Producto,
                               p.Precio,
                               p.Cantidad,
                               p.Subtotal

                           };

            dvCompra.DataSource = tCompras.CopyAnonymusToDataTable();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                MessageBox.Show("Debe haber un registro seleccionado para poder borrarlo");
            }
            else
            {
                if (dvCompra.RowCount == 2)
                {
                    MessageBox.Show("Si eliminas este registro no podras acceder al programa");
                }
                else
                {

                    Variables.Compras.RemoveRange(Variables.Compras.Where(x => x.IdCompra == idCompras));
                    Variables.SaveChanges();
                    Limpiar();
                    CargaDv();
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            DateTime Fechas = Convert.ToDateTime(DateTimes.Value.ToString("yyyy/MM/dd 00:00:00"));

            //  Int64 Fechas = Convert.ToInt64(Fecha);           
            try
            {
                var tSalidas = from p in Variables.Compras
                               where p.Fecha == Fechas
                               select new
                               {
                                   p.IdCompra,
                                   //  p.Fecha,
                                   p.Producto,
                                   p.Precio,
                                   p.Cantidad,
                                   p.Subtotal,
                               };
                dvCompra.DataSource = tSalidas.CopyAnonymusToDataTable();
                dvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch { }
        }

        private void dvCompra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idCompras = Convert.ToInt64(dvCompra.SelectedCells[0].Value);
                var tComidaBebida = Variables.Compras.FirstOrDefault(x => x.IdCompra == idCompras);
                txtCantidad.Text = Convert.ToString( tComidaBebida.Cantidad);
                txtPrecio.Text = Convert.ToString(tComidaBebida.Precio);
                txtProducto.Text = Convert.ToString(tComidaBebida.Producto);
                txtDetalle.Text = Convert.ToString(tComidaBebida.Detalle);
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

        private void dvCompra_MouseClick(object sender, MouseEventArgs e)
        {

            if (log == 1)
            {
                log = 2;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            dvCompra.ClearSelection();
        }
    }
    
}
