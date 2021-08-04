namespace Monte_Carlos.Servicio
{
    partial class Ver_Pedido
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
            this.dvPedidos = new System.Windows.Forms.DataGridView();
            this.dvVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dvPedidos
            // 
            this.dvPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPedidos.Location = new System.Drawing.Point(92, 72);
            this.dvPedidos.Name = "dvPedidos";
            this.dvPedidos.RowHeadersWidth = 51;
            this.dvPedidos.Size = new System.Drawing.Size(194, 363);
            this.dvPedidos.TabIndex = 50;
            // 
            // dvVenta
            // 
            this.dvVenta.BackgroundColor = System.Drawing.Color.White;
            this.dvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvVenta.Location = new System.Drawing.Point(491, 72);
            this.dvVenta.Name = "dvVenta";
            this.dvVenta.RowHeadersWidth = 51;
            this.dvVenta.Size = new System.Drawing.Size(332, 363);
            this.dvVenta.TabIndex = 51;
            this.dvVenta.SelectionChanged += new System.EventHandler(this.dvVenta_SelectionChanged);
            // 
            // Ver_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 468);
            this.Controls.Add(this.dvVenta);
            this.Controls.Add(this.dvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_Pedido";
            this.Text = "Ver_Pedido";
            this.Load += new System.EventHandler(this.Ver_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dvPedidos;
        private System.Windows.Forms.DataGridView dvVenta;
    }
}