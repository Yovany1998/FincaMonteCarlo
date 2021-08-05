namespace Monte_Carlos.Reservaciones
{
    partial class Insertar_Reservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insertar_Reservaciones));
            this.dvReservacion = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnElimicar = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbComida = new System.Windows.Forms.ComboBox();
            this.dvRegistro = new System.Windows.Forms.DataGridView();
            this.Pedidos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvReservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvRegistro)).BeginInit();
            this.Pedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvReservacion
            // 
            this.dvReservacion.BackgroundColor = System.Drawing.Color.White;
            this.dvReservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvReservacion.Location = new System.Drawing.Point(577, 242);
            this.dvReservacion.Name = "dvReservacion";
            this.dvReservacion.RowHeadersWidth = 51;
            this.dvReservacion.Size = new System.Drawing.Size(318, 218);
            this.dvReservacion.TabIndex = 40;
            this.dvReservacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dvReservacion_MouseClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AllowDrop = true;
            this.txtCantidad.Location = new System.Drawing.Point(188, 58);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 24);
            this.txtCantidad.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Pedido:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Peru;
            this.btnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.Image")));
            this.btnInsertar.Location = new System.Drawing.Point(375, 133);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(129, 49);
            this.btnInsertar.TabIndex = 35;
            this.btnInsertar.Text = "Insertar Reservacion";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // txtHora
            // 
            this.txtHora.AllowDrop = true;
            this.txtHora.Location = new System.Drawing.Point(420, 75);
            this.txtHora.Margin = new System.Windows.Forms.Padding(2);
            this.txtHora.Multiline = true;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(132, 24);
            this.txtHora.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Hora:";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(141, 79);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(132, 20);
            this.Fecha.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fecha:";
            // 
            // txtLugar
            // 
            this.txtLugar.AllowDrop = true;
            this.txtLugar.Location = new System.Drawing.Point(699, 26);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(2);
            this.txtLugar.Multiline = true;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(132, 24);
            this.txtLugar.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Reserva zona:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Peru;
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(39, 133);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 49);
            this.btnNuevo.TabIndex = 42;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnElimicar
            // 
            this.btnElimicar.BackColor = System.Drawing.Color.Peru;
            this.btnElimicar.ForeColor = System.Drawing.Color.Black;
            this.btnElimicar.Image = ((System.Drawing.Image)(resources.GetObject("btnElimicar.Image")));
            this.btnElimicar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnElimicar.Location = new System.Drawing.Point(206, 133);
            this.btnElimicar.Name = "btnElimicar";
            this.btnElimicar.Size = new System.Drawing.Size(98, 49);
            this.btnElimicar.TabIndex = 43;
            this.btnElimicar.Text = "Eliminar";
            this.btnElimicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnElimicar.UseVisualStyleBackColor = false;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(143, 26);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(130, 21);
            this.cmbCliente.TabIndex = 44;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.AllowDrop = true;
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(420, 26);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 24);
            this.txtApellido.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Apellido:";
            // 
            // cmbComida
            // 
            this.cmbComida.FormattingEnabled = true;
            this.cmbComida.Location = new System.Drawing.Point(189, 27);
            this.cmbComida.Name = "cmbComida";
            this.cmbComida.Size = new System.Drawing.Size(130, 21);
            this.cmbComida.TabIndex = 47;
            // 
            // dvRegistro
            // 
            this.dvRegistro.BackgroundColor = System.Drawing.Color.White;
            this.dvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvRegistro.Location = new System.Drawing.Point(5, 205);
            this.dvRegistro.Name = "dvRegistro";
            this.dvRegistro.RowHeadersWidth = 51;
            this.dvRegistro.Size = new System.Drawing.Size(544, 255);
            this.dvRegistro.TabIndex = 48;
            this.dvRegistro.SelectionChanged += new System.EventHandler(this.dvRegistro_SelectionChanged);
            this.dvRegistro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dvRegistro_MouseClick);
            // 
            // Pedidos
            // 
            this.Pedidos.BackColor = System.Drawing.Color.Goldenrod;
            this.Pedidos.Controls.Add(this.button1);
            this.Pedidos.Controls.Add(this.cmbComida);
            this.Pedidos.Controls.Add(this.button2);
            this.Pedidos.Controls.Add(this.label4);
            this.Pedidos.Controls.Add(this.label7);
            this.Pedidos.Controls.Add(this.txtCantidad);
            this.Pedidos.Location = new System.Drawing.Point(566, 55);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(335, 401);
            this.Pedidos.TabIndex = 49;
            this.Pedidos.TabStop = false;
            this.Pedidos.Text = "Area de pedidos de la reservacion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(11, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 49);
            this.button1.TabIndex = 51;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(228, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 49);
            this.button2.TabIndex = 50;
            this.button2.Text = "Insertar ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Insertar_Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 468);
            this.Controls.Add(this.dvRegistro);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnElimicar);
            this.Controls.Add(this.dvReservacion);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Insertar_Reservaciones";
            this.Text = "Insertar_Reservaciones";
            this.Load += new System.EventHandler(this.Insertar_Reservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvReservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvRegistro)).EndInit();
            this.Pedidos.ResumeLayout(false);
            this.Pedidos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvReservacion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnElimicar;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbComida;
        private System.Windows.Forms.DataGridView dvRegistro;
        private System.Windows.Forms.GroupBox Pedidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}