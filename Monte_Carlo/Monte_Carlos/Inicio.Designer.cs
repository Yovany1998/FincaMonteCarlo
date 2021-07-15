namespace Monte_Carlos
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnReservaciones = new System.Windows.Forms.Button();
            this.Venta = new System.Windows.Forms.Button();
            this.btnservicio = new System.Windows.Forms.Button();
            this.btnempleado = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.BackColor = System.Drawing.Color.Peru;
            this.btnReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReservaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnReservaciones.Image")));
            this.btnReservaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservaciones.Location = new System.Drawing.Point(149, 132);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Size = new System.Drawing.Size(135, 99);
            this.btnReservaciones.TabIndex = 4;
            this.btnReservaciones.Text = "Reservación";
            this.btnReservaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservaciones.UseVisualStyleBackColor = false;
            this.btnReservaciones.Click += new System.EventHandler(this.btnReservaciones_Click);
            // 
            // Venta
            // 
            this.Venta.BackColor = System.Drawing.Color.Peru;
            this.Venta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Venta.Image = ((System.Drawing.Image)(resources.GetObject("Venta.Image")));
            this.Venta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Venta.Location = new System.Drawing.Point(8, 132);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(135, 99);
            this.Venta.TabIndex = 1;
            this.Venta.Text = "Venta";
            this.Venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Venta.UseVisualStyleBackColor = false;
            this.Venta.Click += new System.EventHandler(this.Venta_Click);
            // 
            // btnservicio
            // 
            this.btnservicio.BackColor = System.Drawing.Color.Peru;
            this.btnservicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnservicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnservicio.Image = ((System.Drawing.Image)(resources.GetObject("btnservicio.Image")));
            this.btnservicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnservicio.Location = new System.Drawing.Point(7, 247);
            this.btnservicio.Name = "btnservicio";
            this.btnservicio.Size = new System.Drawing.Size(135, 93);
            this.btnservicio.TabIndex = 2;
            this.btnservicio.Text = "Pedidos";
            this.btnservicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnservicio.UseVisualStyleBackColor = false;
            this.btnservicio.Click += new System.EventHandler(this.btnservicio_Click);
            // 
            // btnempleado
            // 
            this.btnempleado.BackColor = System.Drawing.Color.Peru;
            this.btnempleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnempleado.Image = ((System.Drawing.Image)(resources.GetObject("btnempleado.Image")));
            this.btnempleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnempleado.Location = new System.Drawing.Point(150, 12);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(135, 102);
            this.btnempleado.TabIndex = 3;
            this.btnempleado.Text = "Empleado";
            this.btnempleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnempleado.UseVisualStyleBackColor = false;
            this.btnempleado.Click += new System.EventHandler(this.btnempleado_Click);
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.Peru;
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncliente.Image = ((System.Drawing.Image)(resources.GetObject("btncliente.Image")));
            this.btncliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncliente.Location = new System.Drawing.Point(148, 247);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(134, 93);
            this.btncliente.TabIndex = 5;
            this.btncliente.Text = "Cliente";
            this.btncliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(8, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "Carta";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, -65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Peru;
            this.lblHora.Location = new System.Drawing.Point(449, 9);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(129, 55);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Peru;
            this.lblFecha.Location = new System.Drawing.Point(673, 9);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 353);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReservaciones);
            this.Controls.Add(this.Venta);
            this.Controls.Add(this.btnservicio);
            this.Controls.Add(this.btnempleado);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReservaciones;
        private System.Windows.Forms.Button Venta;
        private System.Windows.Forms.Button btnservicio;
        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer horafecha;
    }
}