using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Servicio
{
    public partial class Ver_Pedido : Form
    {


        long idVenta = 0;
        MonteCarlo Variables = new MonteCarlo();
      
        public Ver_Pedido()
        {
            InitializeComponent();
          
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
            dvVenta.DataSource = tClientes.CopyAnonymusToDataTable();
            dvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
       

        }



        private void DvPedido()
        {
            try
            {
                idVenta = Convert.ToInt64(dvVenta.SelectedCells[0].Value);
                var tdetalle = from p in Variables.DetalleVenta
                               where p.IdVenta == idVenta
                               select new
                               {
                                   p.Comida,
                                   p.Cantidad,
                               };
                dvPedidos.DataSource = tdetalle.CopyAnonymusToDataTable();
                dvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch { }
          
        }
        public DateTime FechaActual
        {
            get { return DateTime.Today; ; }
            set { this.FechaActual = value; }
        }


        private void Ver_Pedido_Load(object sender, EventArgs e)
        {
            DvClientes();

        }

        private void dvVenta_SelectionChanged(object sender, EventArgs e)
        {
            DvPedido();
         

        }
    }
}
