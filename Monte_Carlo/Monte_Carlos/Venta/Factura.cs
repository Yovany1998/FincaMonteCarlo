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
        Finca_Monte_CarloEntities1 Variables = new Finca_Monte_CarloEntities1();

        public Factura()
        {
            InitializeComponent();

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
            var tMod = from mod in Variables.Facturas
                       select new
                       {
                           mod.IdFactura,
                           mod.Fecha,
                       };

            DataTable dtMod = tMod.CopyAnonymusToDataTable();
            cmbFactura.DataSource = dtMod;
            cmbFactura.ValueMember = dtMod.Columns[0].ColumnName;
            cmbFactura.DisplayMember = dtMod.Columns[1].ColumnName;
        }

        private void llenarFactura()
        {
           

        }

        private void cmbdetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string fee;
            //Int64 IdFactura = Convert.ToInt64(cmbFactura.SelectedValue.ToString());
            //var tFac = Variables.Facturas.FirstOrDefault(x => x.IdFactura == IdFactura);
          // fee = Convert.ToString( tFac.Fecha);



        }

        private void Btndetalle_Click(object sender, EventArgs e)
        {
            // string Fecha = DateTimes.Value.ToString("yyyy/MM/dd 00:00:00");
            DateTime Fecha = Convert.ToDateTime (DateTimes.Value.ToString("yyyy/MM/dd 00:00:00"));

            //  Int64 Fechas = Convert.ToInt64(Fecha);           
            try
            {
                var tFactura = from p in Variables.Facturas
                                    where p.Fecha == Fecha
                               select new
                               {
                                   p.Fecha,
                                   p.NombreCliente,
                                   p.Subtotal,
                                   p.Impuesto,
                                   p.Total,

                               };

                dvFactura.DataSource = tFactura.CopyAnonymusToDataTable();
                // MessageBox.Show(Convert.ToString(dvFactura.F));
                dvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch
            {
                MessageBox.Show("Esa fecha no tiene registro");
            }
         

        }
    }
}
