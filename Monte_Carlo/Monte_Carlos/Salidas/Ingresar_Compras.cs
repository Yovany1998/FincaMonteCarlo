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

        public Ingresar_Compras()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtDetalle.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";

        }

        private void Ingresar_Compras_Load(object sender, EventArgs e)
        {
            var tCompras = from p in Variables.Compras
                                select new
                                {
                                    p.IdCompra,
                                    p.Producto,
                                    p.Precio,
                                    p.Detalle
                                };

            dvCompra.DataSource = tCompras.CopyAnonymusToDataTable();
            dvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idCompras = 0;
            Limpiar();
            editar = false;
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


            if (editar)
            {
                MessageBox.Show("Modifique");
                var tCompra = Variables.Compras.FirstOrDefault(x => x.IdCompra == idCompras);
                tCompra.Producto = txtProducto.Text;
                tCompra.Precio = Convert.ToDouble(txtPrecio.Text);
                tCompra.Detalle = txtDetalle.Text;

                Variables.SaveChanges();
            }
            else
            {
                MessageBox.Show("Guarde");
                Compras tbCompra = new Compras();
                tbCompra.Producto = txtProducto.Text;
                tbCompra.Precio = Convert.ToDouble(txtPrecio.Text);
                tbCompra.Detalle = txtDetalle.Text;
                Variables.Compras.Add(tbCompra);
                Variables.SaveChanges();
            }

            Limpiar();
            editar = false;
            idCompras = 0;

            var tUsuario = from p in Variables.Usuario
                           select new
                           {
                               p.IdUsuario,
                               p.NIdentidad,
                               p.Nombre,
                               p.Estado
                           };

            dvCompra.DataSource = tUsuario.CopyAnonymusToDataTable();

            MessageBox.Show("Informacion guardada!");
            Limpiar();


        }
    }
    
}
