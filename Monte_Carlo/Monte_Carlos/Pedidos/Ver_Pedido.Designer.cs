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
            this.DateTimes = new System.Windows.Forms.DateTimePicker();
            this.Btndetalle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dvFactura = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimes
            // 
            this.DateTimes.Location = new System.Drawing.Point(198, 27);
            this.DateTimes.Name = "DateTimes";
            this.DateTimes.Size = new System.Drawing.Size(200, 20);
            this.DateTimes.TabIndex = 53;
            // 
            // Btndetalle
            // 
            this.Btndetalle.BackColor = System.Drawing.Color.Peru;
            this.Btndetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndetalle.Location = new System.Drawing.Point(438, 16);
            this.Btndetalle.Name = "Btndetalle";
            this.Btndetalle.Size = new System.Drawing.Size(131, 45);
            this.Btndetalle.TabIndex = 52;
            this.Btndetalle.Text = "Desplegar";
            this.Btndetalle.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Pedidos por fecha:";
            // 
            // dvFactura
            // 
            this.dvFactura.BackgroundColor = System.Drawing.Color.White;
            this.dvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvFactura.Location = new System.Drawing.Point(47, 72);
            this.dvFactura.Name = "dvFactura";
            this.dvFactura.RowHeadersWidth = 51;
            this.dvFactura.Size = new System.Drawing.Size(522, 238);
            this.dvFactura.TabIndex = 50;
            // 
            // Ver_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 472);
            this.Controls.Add(this.DateTimes);
            this.Controls.Add(this.Btndetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dvFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_Pedido";
            this.Text = "Ver_Pedido";
            this.Load += new System.EventHandler(this.Ver_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimes;
        private System.Windows.Forms.Button Btndetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dvFactura;
    }
}