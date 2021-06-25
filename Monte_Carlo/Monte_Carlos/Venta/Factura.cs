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
    public partial class Factura : Form
    {
        int contador;
        Conexion conexion;

        public Factura()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Venta ventana = new Menu_Venta();
            ventana.Show();
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            llenarFactura();
           // DataTable Datos = conexion.consulta(String.Format("SELECT a.IdFactura,a.FechaActual as 'Fecha de venta',b.nombre as 'Nombre del cliente',c.nombre as 'Nombre del empleado', d.total as 'Total del detalle de venta',sum(total) FROM ventas_comedor.factura a join ventas_comedor.cliente b on a.idCliente =b.idCliente  join  ventas_comedor.empleado c on c.idEmpleado =a.IdEmpleado join  ventas_comedor.detalledefactura d on d.idFactura = a.idFactura;"));
            //dgvFactura.DataSource = Datos;
            //dgvFactura.Refresh();
        }

        private void llenarFactura()
        {
            DataTable comida = new DataTable();
            Conexion nuevo = new Conexion();
            comida = nuevo.consulta(string.Format("SELECT * FROM ventas_comedor.factura"));
            cmbdetalle.DataSource = null;
            cmbdetalle.Items.Clear();
            cmbdetalle.ValueMember = comida.Columns["idfactura"].ColumnName;
            cmbdetalle.DisplayMember = comida.Columns["idfactura"].ColumnName;
            cmbdetalle.DataSource = comida;
            cmbdetalle.SelectedIndex = -1;
            cmbdetalle.Text = "Selecciona una opcion";

        }

        private void cmbdetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            contador = contador + 1;


            if (contador > 2)
            {
                DataTable Datos = conexion.consulta(String.Format("SELECT a.IdFactura,a.FechaActual as 'Fecha de venta',b.nombre as 'Nombre del cliente',c.nombre as 'Nombre del empleado',sum(total) as 'Total a pagar de la venta' FROM ventas_comedor.factura a join ventas_comedor.cliente b on a.idCliente =b.idCliente  join  ventas_comedor.empleado c on c.idEmpleado =a.IdEmpleado join  ventas_comedor.detalledefactura d on d.idFactura = a.idFactura where a.idFactura ={0};",cmbdetalle.Text));
                dgvFactura.DataSource = Datos;
                dgvFactura.Refresh();
               // contador = 1;



            }
        }

        private void Btndetalle_Click(object sender, EventArgs e)
        {
            DataTable Datos = conexion.consulta(String.Format("SELECT a.IdFactura,a.FechaActual as 'Fecha de venta',b.nombre as 'Nombre del cliente',c.nombre as 'Nombre del empleado',d.total as 'Total detalle' FROM ventas_comedor.factura a join ventas_comedor.cliente b on a.idCliente =b.idCliente  join  ventas_comedor.empleado c on c.idEmpleado =a.IdEmpleado join  ventas_comedor.detalledefactura d on d.idFactura = a.idFactura;"));
            dgvFactura.DataSource = Datos;
            dgvFactura.Refresh();
            // contador = 1;

        }
    }
}
