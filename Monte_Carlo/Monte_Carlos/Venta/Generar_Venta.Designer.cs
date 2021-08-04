namespace Monte_Carlos.Venta
{
    partial class Generar_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generar_Venta));
            this.BtnGenerarVenta = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.dvVenta = new System.Windows.Forms.DataGridView();
            this.btnVenta = new System.Windows.Forms.Button();
            this.cmbComidaBebida = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbImpuesto = new System.Windows.Forms.ComboBox();
            this.pedido = new System.Windows.Forms.Label();
            this.dvCliente = new System.Windows.Forms.DataGridView();
            this.Pagado = new System.Windows.Forms.CheckBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGenerarVenta
            // 
            this.BtnGenerarVenta.BackColor = System.Drawing.Color.Peru;
            this.BtnGenerarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnGenerarVenta.Image")));
            this.BtnGenerarVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGenerarVenta.Location = new System.Drawing.Point(29, 206);
            this.BtnGenerarVenta.Name = "BtnGenerarVenta";
            this.BtnGenerarVenta.Size = new System.Drawing.Size(142, 49);
            this.BtnGenerarVenta.TabIndex = 8;
            this.BtnGenerarVenta.Text = "Generar Venta";
            this.BtnGenerarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGenerarVenta.UseVisualStyleBackColor = false;
            this.BtnGenerarVenta.Click += new System.EventHandler(this.BtnGenerarVenta_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Peru;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.Location = new System.Drawing.Point(317, 206);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 49);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Eliminar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.Color.Peru;
            this.BtnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("BtnInsertar.Image")));
            this.BtnInsertar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnInsertar.Location = new System.Drawing.Point(437, 206);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(98, 49);
            this.BtnInsertar.TabIndex = 6;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(156, 168);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(350, 132);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(109, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Enabled = false;
            this.txtIdVenta.Location = new System.Drawing.Point(155, 80);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdVenta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(27, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(272, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(23, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Comida Bebida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Venta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(476, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Total Venta";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.PeachPuff;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Total.Location = new System.Drawing.Point(479, 98);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(25, 13);
            this.Total.TabIndex = 34;
            this.Total.Text = "0.0";
            // 
            // dvVenta
            // 
            this.dvVenta.BackgroundColor = System.Drawing.Color.White;
            this.dvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvVenta.Location = new System.Drawing.Point(30, 283);
            this.dvVenta.Name = "dvVenta";
            this.dvVenta.RowHeadersWidth = 51;
            this.dvVenta.Size = new System.Drawing.Size(581, 162);
            this.dvVenta.TabIndex = 43;
            this.dvVenta.SelectionChanged += new System.EventHandler(this.dvVenta_SelectionChanged);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Peru;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Location = new System.Drawing.Point(481, 37);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(54, 23);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbComidaBebida
            // 
            this.cmbComidaBebida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbComidaBebida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbComidaBebida.FormattingEnabled = true;
            this.cmbComidaBebida.Location = new System.Drawing.Point(155, 126);
            this.cmbComidaBebida.Margin = new System.Windows.Forms.Padding(2);
            this.cmbComidaBebida.Name = "cmbComidaBebida";
            this.cmbComidaBebida.Size = new System.Drawing.Size(100, 21);
            this.cmbComidaBebida.TabIndex = 45;
            this.cmbComidaBebida.SelectedIndexChanged += new System.EventHandler(this.cmbComida_SelectedIndexChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(155, 35);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(100, 21);
            this.cmbCliente.TabIndex = 48;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(269, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(350, 40);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(109, 20);
            this.txtApellido.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(268, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "Impuesto";
            // 
            // cmbImpuesto
            // 
            this.cmbImpuesto.FormattingEnabled = true;
            this.cmbImpuesto.Items.AddRange(new object[] {
            "Exento",
            "15%",
            "18%"});
            this.cmbImpuesto.Location = new System.Drawing.Point(351, 169);
            this.cmbImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbImpuesto.Name = "cmbImpuesto";
            this.cmbImpuesto.Size = new System.Drawing.Size(108, 21);
            this.cmbImpuesto.TabIndex = 53;
            // 
            // pedido
            // 
            this.pedido.AutoSize = true;
            this.pedido.BackColor = System.Drawing.Color.Transparent;
            this.pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pedido.Location = new System.Drawing.Point(473, 141);
            this.pedido.Name = "pedido";
            this.pedido.Size = new System.Drawing.Size(46, 13);
            this.pedido.TabIndex = 55;
            this.pedido.Text = "Estado";
            // 
            // dvCliente
            // 
            this.dvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCliente.Location = new System.Drawing.Point(628, 28);
            this.dvCliente.Name = "dvCliente";
            this.dvCliente.RowHeadersWidth = 51;
            this.dvCliente.Size = new System.Drawing.Size(262, 382);
            this.dvCliente.TabIndex = 56;
            this.dvCliente.SelectionChanged += new System.EventHandler(this.dvCliente_SelectionChanged);
            this.dvCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dvCliente_MouseMove);
            // 
            // Pagado
            // 
            this.Pagado.AutoSize = true;
            this.Pagado.Location = new System.Drawing.Point(482, 169);
            this.Pagado.Name = "Pagado";
            this.Pagado.Size = new System.Drawing.Size(63, 17);
            this.Pagado.TabIndex = 57;
            this.Pagado.Text = "Pagado";
            this.Pagado.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Peru;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitar.Location = new System.Drawing.Point(727, 416);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(98, 49);
            this.btnQuitar.TabIndex = 58;
            this.btnQuitar.Text = "Quitar elección";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Peru;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(183, 206);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 49);
            this.btnLimpiar.TabIndex = 59;
            this.btnLimpiar.Text = "Nueva Venta";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Generar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 468);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.Pagado);
            this.Controls.Add(this.dvCliente);
            this.Controls.Add(this.pedido);
            this.Controls.Add(this.cmbImpuesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbComidaBebida);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.dvVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGenerarVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generar_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar_Venta";
            this.Load += new System.EventHandler(this.Generar_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGenerarVenta;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.DataGridView dvVenta;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.ComboBox cmbComidaBebida;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbImpuesto;
        private System.Windows.Forms.Label pedido;
        private System.Windows.Forms.DataGridView dvCliente;
        private System.Windows.Forms.CheckBox Pagado;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}