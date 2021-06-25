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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsertarCliente = new System.Windows.Forms.Button();
            this.dvClientes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.AllowDrop = true;
            this.txtApellido.Location = new System.Drawing.Point(221, 226);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(196, 27);
            this.txtApellido.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Location = new System.Drawing.Point(221, 170);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 29);
            this.txtNombre.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 70);
            this.panel1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 70);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cliente";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Monte_Carlos.Properties.Resources.conjunto_ilustracion_logotipo_restaurante_vintage_23_2148470301;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Monte_Carlos.Properties.Resources._64497;
            this.pictureBox1.Location = new System.Drawing.Point(669, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.AllowDrop = true;
            this.txtIdCliente.Location = new System.Drawing.Point(221, 111);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCliente.Multiline = true;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(196, 29);
            this.txtIdCliente.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 33;
            this.label1.Text = "Codigo Cliente:";
            // 
            // txtInsertarCliente
            // 
            this.txtInsertarCliente.Location = new System.Drawing.Point(493, 214);
            this.txtInsertarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInsertarCliente.Name = "txtInsertarCliente";
            this.txtInsertarCliente.Size = new System.Drawing.Size(131, 48);
            this.txtInsertarCliente.TabIndex = 43;
            this.txtInsertarCliente.Text = "Insertar";
            this.txtInsertarCliente.UseVisualStyleBackColor = true;
            this.txtInsertarCliente.Click += new System.EventHandler(this.txtInsertarCliente_Click);
            // 
            // dvClientes
            // 
            this.dvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvClientes.Location = new System.Drawing.Point(43, 293);
            this.dvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvClientes.Name = "dvClientes";
            this.dvClientes.RowHeadersWidth = 51;
            this.dvClientes.Size = new System.Drawing.Size(684, 231);
            this.dvClientes.TabIndex = 44;
            this.dvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvClientes_CellContentClick);
            // 
            // Insertar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 571);
            this.Controls.Add(this.dvClientes);
            this.Controls.Add(this.txtInsertarCliente);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Insertar_Cliente";
            this.Text = "Insertar_Cliente";
            this.Load += new System.EventHandler(this.Insertar_Cliente_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtInsertarCliente;
        private System.Windows.Forms.DataGridView dvClientes;
    }
}