using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Monte_Carlos.Venta
{
    public partial class Factura : Form
    {
        int contador;

        Double sali;
        String LaFecha = "";
        private double total;
        MonteCarlo Variables = new MonteCarlo();
        string imagen = @"C:\Users\Hernandez Garcia\Desktop\Repositorio nuevo\FincaMonteCarlo\Monte_Carlo\Monte_Carlos\Resources\Logo.jpeg";

        public Factura()
        {
            InitializeComponent();

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
         
        }

        private void Limpiar()
        {
            lbTotal.Text = "0";
            lbTotVentas.Text = "0";
            TotalSalidas.Text = "0";

        }

        private void cmbdetalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btndetalle_Click(object sender, EventArgs e)
        {
            Limpiar();
            // string Fecha = DateTimes.Value.ToString("yyyy/MM/dd 00:00:00");
            DateTime Fechas = Convert.ToDateTime (DateTimes.Value.ToString("yyyy/MM/dd 00:00:00"));

            //  Int64 Fechas = Convert.ToInt64(Fecha);           
            try
            {
                var tFactura = from p in Variables.Facturas
                                    where p.Fecha == Fechas
                               select new
                               {
                                   p.IdFactura,
                                   p.Fecha,
                                   p.NombreCliente,                                   
                                   p.Subtotal,
                                   p.Impuesto,
                                   p.Total,
                               };
                dvFactura.DataSource = tFactura.CopyAnonymusToDataTable();
                dvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                contador = dvFactura.RowCount-1;
                lbTotVentas.Text = Convert.ToString(contador);
                DateTime FechaNormal = Convert.ToDateTime(DateTimes.Value.ToString("yyyy/MM/dd"));
                LaFecha = Convert.ToString(FechaNormal);
            }
            catch
            {
                Limpiar();
                MessageBox.Show("Esa fecha no tiene registro");
            }
            
         
            try
            {
                foreach (DataGridViewRow row in dvFactura.Rows)
                {
                   total=total+Convert.ToDouble(row.Cells[5].Value.ToString());
                    lbTotal.Text = Convert.ToString(total);
                }
            }
            catch { }

          

            //   total = 0;

            //Todo esto es de salidas
            try
            {
                var tCompras= from p in Variables.Compras
                               where p.Fecha == Fechas
                               select new
                               {
                                 p.Producto,
                                 p.Cantidad,
                                 p.Precio,
                                 p.Subtotal
                               };
                dvSalidas.DataSource = tCompras.CopyAnonymusToDataTable();
                dvSalidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch
            {
                MessageBox.Show("Esa fecha no tiene registro");
            }
            try
            {

                foreach (DataGridViewRow row in dvSalidas.Rows)
                {
                    sali = sali + Convert.ToDouble(row.Cells[3].Value.ToString());
                    TotalSalidas.Text = Convert.ToString(sali);
                }
            }
            catch { }
        }
        private void ImprimirFactura()
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            //Dialogo
            printDocument1.Print();

        }
        private void Imprimir(object sender,PrintPageEventArgs e)
        {
            //Configuración para la factura( tipo de letra,
            //ancho total de la factura, separación entre textos
            //tipos de alineado
            Font font = new Font("Arial", 12,FontStyle.Regular, GraphicsUnit.Point);
            Font Emcabezado = new Font("Arial", 12,FontStyle.Bold, GraphicsUnit.Point);
            int ancho = 300;
            int MargenSuperior = 50;
            int ReporteDiario = 240;
            int y = 0;
            int Columna1 = 80;
            int Columna2 = 160;
            int Columna3 = 440;
            int Columna4 = 540;
            int Columna5 = 640;
            int Columna6 = 740;
            StringFormat stringFormatLeft = new StringFormat();
            stringFormatLeft.Alignment = StringAlignment.Near;
            stringFormatLeft.LineAlignment = StringAlignment.Near;
            Image image = Image.FromFile(imagen);
            e.Graphics.DrawString("REPORTE DIARIO DE FINCA MONTECARLO  ", Emcabezado, Brushes.Black, new RectangleF(ReporteDiario, MargenSuperior, 1000, 0), stringFormatLeft);
            //La fecha que seleccione
            e.Graphics.DrawString("Fecha " + LaFecha, Emcabezado, Brushes.Black, new RectangleF(Columna1, MargenSuperior+40, ancho, 0), stringFormatLeft);
            //La imagen
            e.Graphics.DrawImage(image, new Rectangle(700,MargenSuperior,100,100));
            e.Graphics.DrawString("ENTRADAS", Emcabezado, Brushes.Black, new RectangleF(Columna1, MargenSuperior+80, 1000, 0), stringFormatLeft);
            MargenSuperior =MargenSuperior*3+20;
            int Mat = MargenSuperior - 20;
            e.Graphics.DrawString("_______________________________________________________________________", Emcabezado, Brushes.Black, new RectangleF(Columna1, Mat, Columna6, 0), stringFormatLeft);
            e.Graphics.DrawString("|Numero ", Emcabezado, Brushes.Black, new RectangleF(Columna1,MargenSuperior, ancho, 0), stringFormatLeft);
            e.Graphics.DrawString("|Cliente ", Emcabezado, Brushes.Black, new RectangleF(Columna2, MargenSuperior, ancho, 0), stringFormatLeft);
            e.Graphics.DrawString("|SubTotal ", Emcabezado, Brushes.Black, new RectangleF(Columna3, MargenSuperior, ancho, 0), stringFormatLeft);
            e.Graphics.DrawString("|Impuesto ", Emcabezado, Brushes.Black, new RectangleF(Columna4, MargenSuperior, ancho, 0), stringFormatLeft);
            e.Graphics.DrawString("|Total ", Emcabezado, Brushes.Black, new RectangleF(Columna5, MargenSuperior, ancho, 0), stringFormatLeft);
            e.Graphics.DrawString("|", Emcabezado, Brushes.Black, new RectangleF(Columna6, MargenSuperior, ancho, 0), stringFormatLeft);
            e.Graphics.DrawString("", Emcabezado, Brushes.Black, new RectangleF(0, 20, ancho, 0), stringFormatLeft);
            try                 
            {
                int Num = 0;
                y = y + MargenSuperior;
                foreach (DataGridViewRow row in dvFactura.Rows)
                {
                    Num++;
                   // y = y + 2;
                    e.Graphics.DrawString("_______________________________________________________________________", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, Columna6, 0), stringFormatLeft);
                    y = y + 20;
                    if(row.Cells[2].Value.ToString() != "")
                    {
                        e.Graphics.DrawString("|" + Num, font, Brushes.Black, new RectangleF(Columna1, y, ancho, 0), stringFormatLeft);
                    }                
                    e.Graphics.DrawString("|" + row.Cells[2].Value.ToString() + "", font, Brushes.Black, new RectangleF(Columna2, y, ancho, 0), stringFormatLeft);
                    e.Graphics.DrawString("|" + "L. "+row.Cells[3].Value.ToString() + "", font, Brushes.Black, new RectangleF(Columna3, y, ancho, 0), stringFormatLeft);
                    e.Graphics.DrawString("|" + "L. " + row.Cells[4].Value.ToString() + "", font, Brushes.Black, new RectangleF(Columna4, y, ancho, 0), stringFormatLeft);
                    e.Graphics.DrawString("|" + "L. " + row.Cells[5].Value.ToString() + "", font, Brushes.Black, new RectangleF(Columna5, y, ancho, 0), stringFormatLeft);
                    e.Graphics.DrawString("|", font, Brushes.Black, new RectangleF(Columna6, y, ancho, 0), stringFormatLeft);

                    //  e.Graphics.DrawString(row.Cells[2].Value.ToString() + " X " + row.Cells[3].Value.ToString(), font, Brushes.Black, new RectangleF(0, y += 25, ancho, 20), stringFormatLeft);
                }
            }
            catch { }
            try
            {
                e.Graphics.DrawString("|"  + "Total de Ventas", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|" + "L. " + lbTotal.Text + "", Emcabezado, Brushes.Black, new RectangleF(Columna5, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|", Emcabezado, Brushes.Black, new RectangleF(Columna6, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("_______________________________________________________________________", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, Columna6, 0), stringFormatLeft);
                y = y + 20;
                e.Graphics.DrawString("|" + "Total de Salidas", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|" + "L. " + TotalSalidas.Text + "", Emcabezado, Brushes.Black, new RectangleF(Columna5, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|", Emcabezado, Brushes.Black, new RectangleF(Columna6, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("_______________________________________________________________________", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, Columna6, 0), stringFormatLeft);
                Double resta = (Convert.ToDouble(lbTotal.Text) - Convert.ToDouble(TotalSalidas.Text));
                y = y + 20;
                e.Graphics.DrawString("|" + "", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|" + "L. " + Convert.ToString(resta) + "", Emcabezado, Brushes.Black, new RectangleF(Columna5, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|", Emcabezado, Brushes.Black, new RectangleF(Columna6, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("_______________________________________________________________________", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, Columna6, 0), stringFormatLeft);
                y = y + 20;
                e.Graphics.DrawString("|" + "Caja Anterior", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|" + "L. " + Convert.ToString(txtCajaAnterior.Text) + "", Emcabezado, Brushes.Black, new RectangleF(Columna5, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|", Emcabezado, Brushes.Black, new RectangleF(Columna6, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("_______________________________________________________________________", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, Columna6, 0), stringFormatLeft);
                y = y + 20;
                e.Graphics.DrawString("|" + "Dinero Contado", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|" + "L. " + Convert.ToString(txtDineroContado.Text) + "", Emcabezado, Brushes.Black, new RectangleF(Columna5, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|", Emcabezado, Brushes.Black, new RectangleF(Columna6, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("_______________________________________________________________________", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, Columna6, 0), stringFormatLeft);
                y = y + 20;
                double Total = Convert.ToDouble(txtDineroContado.Text) - (resta + Convert.ToDouble(txtCajaAnterior.Text));
                e.Graphics.DrawString("|" + "Total De dinero", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|" + "L. " + Convert.ToString(Total) + "", Emcabezado, Brushes.Black, new RectangleF(Columna5, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("|", Emcabezado, Brushes.Black, new RectangleF(Columna6, y, ancho, 0), stringFormatLeft);
                e.Graphics.DrawString("_______________________________________________________________________", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, Columna6, 0), stringFormatLeft);
                /*
                                Columna1 = 80;
                                 Columna2 = 180;
                                 Columna3 = 280;
                                Columna4 = 380;
                                 Columna5 = 480;
                                Columna6 = 580;

                                int Nume = 0;
                                y = y + 60;
                                e.Graphics.DrawString("SALIDAS", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, 1000, 0), stringFormatLeft);
                                y = y + 20;
                                e.Graphics.DrawString("______________________________________________________", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, Columna6, 0), stringFormatLeft);
                                e.Graphics.DrawString("|Numero ", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, ancho, 0), stringFormatLeft);
                                e.Graphics.DrawString("|Producto ", Emcabezado, Brushes.Black, new RectangleF(Columna2, y, ancho, 0), stringFormatLeft);
                                e.Graphics.DrawString("|Cantidad ", Emcabezado, Brushes.Black, new RectangleF(Columna3, y, ancho, 0), stringFormatLeft);
                                e.Graphics.DrawString("|Precio ", Emcabezado, Brushes.Black, new RectangleF(Columna4, y, ancho, 0), stringFormatLeft);
                                e.Graphics.DrawString("|Subtotal", Emcabezado, Brushes.Black, new RectangleF(Columna5, y, ancho, 0), stringFormatLeft);
                                e.Graphics.DrawString("|", font, Brushes.Black, new RectangleF(Columna6, y, ancho, 0), stringFormatLeft);
                                foreach (DataGridViewRow row in dvSalidas.Rows)
                                {
                                    Nume++;
                                    // y = y + 2;
                                    e.Graphics.DrawString("______________________________________________________", Emcabezado, Brushes.Black, new RectangleF(Columna1, y, Columna6, 0), stringFormatLeft);
                                    y = y + 20;
                                    if (row.Cells[2].Value.ToString() != "")
                                    {
                                        e.Graphics.DrawString("|" + Nume, font, Brushes.Black, new RectangleF(Columna1, y, ancho, 0), stringFormatLeft);
                                    }
                                    e.Graphics.DrawString("|" + row.Cells[0].Value.ToString() + "", font, Brushes.Black, new RectangleF(Columna2, y, ancho, 0), stringFormatLeft);
                                    e.Graphics.DrawString("|" + row.Cells[1].Value.ToString() + "", font, Brushes.Black, new RectangleF(Columna3, y, ancho, 0), stringFormatLeft);
                                    e.Graphics.DrawString("|" + "L. " + row.Cells[2].Value.ToString() + "", font, Brushes.Black, new RectangleF(Columna4, y, ancho, 0), stringFormatLeft);
                                    e.Graphics.DrawString("|" + "L. " + row.Cells[3].Value.ToString() + "", font, Brushes.Black, new RectangleF(Columna5, y, ancho, 0), stringFormatLeft);
                                    e.Graphics.DrawString("|", font, Brushes.Black, new RectangleF(Columna6, y, ancho, 0), stringFormatLeft);

                                    //  e.Graphics.DrawString(row.Cells[2].Value.ToString() + " X " + row.Cells[3].Value.ToString(), font, Brushes.Black, new RectangleF(0, y += 25, ancho, 20), stringFormatLeft);
                                }
                */
            }

            catch { }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirFactura();
        }
    }
}
