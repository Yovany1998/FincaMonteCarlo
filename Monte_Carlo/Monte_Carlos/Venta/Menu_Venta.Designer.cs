namespace Monte_Carlos.Venta
{
    partial class Menu_Venta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.btnInsertarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Monte_Carlos.Properties.Resources.conjunto_ilustracion_logotipo_restaurante_vintage_23_2148470301;
            this.pictureBox1.Location = new System.Drawing.Point(30, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 38);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu Venta";
            this.label1.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(0, 0);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(46, 41);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "←";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.BackColor = System.Drawing.Color.Peru;
            this.btnModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPedido.Location = new System.Drawing.Point(266, 353);
            this.btnModificarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(177, 66);
            this.btnModificarPedido.TabIndex = 13;
            this.btnModificarPedido.Text = "Factura";
            this.btnModificarPedido.UseVisualStyleBackColor = false;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnInsertarPedido
            // 
            this.btnInsertarPedido.BackColor = System.Drawing.Color.Peru;
            this.btnInsertarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarPedido.Location = new System.Drawing.Point(40, 353);
            this.btnInsertarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertarPedido.Name = "btnInsertarPedido";
            this.btnInsertarPedido.Size = new System.Drawing.Size(177, 66);
            this.btnInsertarPedido.TabIndex = 12;
            this.btnInsertarPedido.Text = "Insertar Venta";
            this.btnInsertarPedido.UseVisualStyleBackColor = false;
            this.btnInsertarPedido.Click += new System.EventHandler(this.btnGenerarVenta_Click);
            // 
            // Menu_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.btnInsertarPedido);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu_Venta";
            this.Text = "Menu_Venta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.Button btnInsertarPedido;
    }
}