using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Monte_Carlos.Venta
{
    public partial class Reporte_Ventas : Form
    {
        private String NombreCliente;
        private int Contador1;
        private string conca;
        private double suma;
        private string[] seriesArray;

        Finca_Monte_CarloEntities1 Variables = new Finca_Monte_CarloEntities1();
            
        public Reporte_Ventas()
        {
            InitializeComponent();
        }

        private void Reporte_Ventas_Load(object sender, EventArgs e)
        {
            
        ProductosCategoria();
        }
        public void ProductosCategoria()
        {
            string[] seriesArray;

            var tMod = from t in Variables.DetalleVenta
                       select new
                       {
                           t.IdCliente,
                         //  t.Subtotal,
                       };
            Contador1 = Variables.Facturas.Count();
            for (int y=0; y < Contador1; y++)
            {
                
                suma = 0;
                    var rowNomCli = Variables.Clientes.FirstOrDefault(x => x.IdCliente == y + 1);
                    NombreCliente = Convert.ToString(rowNomCli.Nombre);
                    conca = conca + "," + NombreCliente;
                string[] coleccion = { Convert.ToString(NombreCliente) };
                try
                {
                    var rowNom = Variables.Facturas.FirstOrDefault(x => x.IdCliente == rowNomCli.IdCliente);
                    if(rowNom.IdCliente== rowNomCli.IdCliente)
                    {
                        suma = suma + Convert.ToInt32(rowNom.Total);
                    }
                    int sub = Convert.ToInt32(suma);
                    // conca = conca + "," + NombreCliente;

                    int[] pointsArray = { sub };

                    this.CharProductos.Palette = ChartColorPalette.SeaGreen;
                    // Se agrega un titulo al Grafico
                    if (y == 0)
                    {
                        this.CharProductos.Titles.Add("Clientes con mayor consumo");
                    }

                    // Agregar las Series al Grafico.
                    for (int i = 0; i < coleccion.Length; i++)
                    {

                        // Aqui se agregan las series o Categorias.
                        Series series = this.CharProductos.Series.Add(coleccion[i]);
                        // Aqui se agregan los Valores.
                        series.Points.Add(pointsArray[i]);

                    }


                }
                catch
                {

                }



            }

            // DataTable dtMod = tMod.CopyAnonymusToDataTable
          //  string[] seriesArray = Convert.ToChar( conca));
            //string[] seriesArray = { Convert.ToString(conca) };
            // string[] seriesArray = {Convert.ToString(NombreCliente)};
            var tDop = from t in Variables.DetalleVenta
                       select new
                       {
                          // t.IdCliente,
                             t.IdVenta,
                       };
           
        }

        public void Producto()
        {
            // Arreglos del Grafico
            string[] seriesArray = { "Categoria 1", "Categoria 2", "Categoria 3" };
            int[] pointsArray = { Convert.ToInt32("10"), Convert.ToInt32("303"), Convert.ToInt32("90") };
            // Se modifica la Paleta de Colores a utilizar por el control.
            this.CharProductos.Palette = ChartColorPalette.SeaGreen;
            // Se agrega un titulo al Grafico.
            this.CharProductos.Titles.Add("Categorias");
            // Agregar las Series al Grafico.
            for (int i = 0; i < seriesArray.Length; i++)
            {

                // Aqui se agregan las series o Categorias.
                Series series = this.CharProductos.Series.Add(seriesArray[i]);
                // Aqui se agregan los Valores.
                series.Points.Add(pointsArray[i]);

            }
        }

        private void CharProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
