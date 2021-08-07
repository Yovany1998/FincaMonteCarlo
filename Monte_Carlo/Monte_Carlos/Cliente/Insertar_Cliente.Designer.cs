namespace Monte_Carlos.Cliente
{
    partial class Insertar_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insertar_Cliente));
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsertarCliente = new System.Windows.Forms.Button();
            this.dvClientes = new System.Windows.Forms.DataGridView();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnElimicar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.AllowDrop = true;
            this.txtApellido.Location = new System.Drawing.Point(680, 32);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(148, 23);
            this.txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Location = new System.Drawing.Point(414, 31);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre:";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.AllowDrop = true;
            this.txtIdentidad.Location = new System.Drawing.Point(177, 31);
            this.txtIdentidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentidad.MaxLength = 15;
            this.txtIdentidad.Multiline = true;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(148, 24);
            this.txtIdentidad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Numero Identidad:";
            // 
            // txtInsertarCliente
            // 
            this.txtInsertarCliente.BackColor = System.Drawing.Color.Peru;
            this.txtInsertarCliente.ForeColor = System.Drawing.Color.Black;
            this.txtInsertarCliente.Image = ((System.Drawing.Image)(resources.GetObject("txtInsertarCliente.Image")));
            this.txtInsertarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtInsertarCliente.Location = new System.Drawing.Point(611, 127);
            this.txtInsertarCliente.Name = "txtInsertarCliente";
            this.txtInsertarCliente.Size = new System.Drawing.Size(98, 49);
            this.txtInsertarCliente.TabIndex = 6;
            this.txtInsertarCliente.Text = "Insertar";
            this.txtInsertarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtInsertarCliente.UseVisualStyleBackColor = false;
            this.txtInsertarCliente.Click += new System.EventHandler(this.txtInsertarCliente_Click);
            // 
            // dvClientes
            // 
            this.dvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvClientes.Location = new System.Drawing.Point(128, 182);
            this.dvClientes.Name = "dvClientes";
            this.dvClientes.RowHeadersWidth = 51;
            this.dvClientes.Size = new System.Drawing.Size(643, 257);
            this.dvClientes.TabIndex = 44;
            this.dvClientes.SelectionChanged += new System.EventHandler(this.dvClientes_SelectionChanged);
            this.dvClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dvClientes_MouseClick);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AllowDrop = true;
            this.txtTelefono.Location = new System.Drawing.Point(177, 72);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(148, 23);
            this.txtTelefono.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Telefonico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AllowDrop = true;
            this.txtCorreo.Location = new System.Drawing.Point(680, 70);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(148, 23);
            this.txtCorreo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(582, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Correo :";
            // 
            // txtEdad
            // 
            this.txtEdad.AllowDrop = true;
            this.txtEdad.Location = new System.Drawing.Point(414, 71);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(148, 23);
            this.txtEdad.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Edad:";
            // 
            // btnElimicar
            // 
            this.btnElimicar.BackColor = System.Drawing.Color.Peru;
            this.btnElimicar.ForeColor = System.Drawing.Color.Black;
            this.btnElimicar.Image = ((System.Drawing.Image)(resources.GetObject("btnElimicar.Image")));
            this.btnElimicar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnElimicar.Location = new System.Drawing.Point(388, 127);
            this.btnElimicar.Name = "btnElimicar";
            this.btnElimicar.Size = new System.Drawing.Size(98, 49);
            this.btnElimicar.TabIndex = 7;
            this.btnElimicar.Text = "Eliminar";
            this.btnElimicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnElimicar.UseVisualStyleBackColor = false;
            this.btnElimicar.Click += new System.EventHandler(this.btnElimicar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Peru;
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(177, 127);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 49);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Insertar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 468);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnElimicar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dvClientes);
            this.Controls.Add(this.txtInsertarCliente);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insertar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar_Cliente";
            this.Load += new System.EventHandler(this.Insertar_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtInsertarCliente;
        private System.Windows.Forms.DataGridView dvClientes;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnElimicar;
        private System.Windows.Forms.Button btnNuevo;
    }
}