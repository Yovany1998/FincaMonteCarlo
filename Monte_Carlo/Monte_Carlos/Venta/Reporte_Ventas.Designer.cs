
namespace Monte_Carlos.Venta
{
    partial class Reporte_Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CharProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CharProductosPreferidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.CharProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharProductosPreferidos)).BeginInit();
            this.SuspendLayout();
            // 
            // CharProductos
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.CharProductos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CharProductos.Legends.Add(legend1);
            this.CharProductos.Location = new System.Drawing.Point(12, 63);
            this.CharProductos.Name = "CharProductos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CharProductos.Series.Add(series1);
            this.CharProductos.Size = new System.Drawing.Size(300, 300);
            this.CharProductos.TabIndex = 0;
            this.CharProductos.Text = "chart1";
            this.CharProductos.Click += new System.EventHandler(this.CharProductos_Click);
            // 
            // CharProductosPreferidos
            // 
            chartArea2.Name = "ChartArea1";
            this.CharProductosPreferidos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.CharProductosPreferidos.Legends.Add(legend2);
            this.CharProductosPreferidos.Location = new System.Drawing.Point(345, 63);
            this.CharProductosPreferidos.Name = "CharProductosPreferidos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.CharProductosPreferidos.Series.Add(series2);
            this.CharProductosPreferidos.Size = new System.Drawing.Size(300, 300);
            this.CharProductosPreferidos.TabIndex = 1;
            this.CharProductosPreferidos.Text = "chart2";
            // 
            // Reporte_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.CharProductosPreferidos);
            this.Controls.Add(this.CharProductos);
            this.Name = "Reporte_Ventas";
            this.Text = "Reporte_Ventas";
            this.Load += new System.EventHandler(this.Reporte_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CharProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharProductosPreferidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CharProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart CharProductosPreferidos;
    }
}