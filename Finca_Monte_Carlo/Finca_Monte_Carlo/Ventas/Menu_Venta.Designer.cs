
namespace Finca_Monte_Carlo
{
    partial class Menu_Venta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Venta));
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
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 31);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu Venta";
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
            this.btnReturn.Size = new System.Drawing.Size(34, 33);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "←";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.BackColor = System.Drawing.Color.Peru;
            this.btnModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPedido.Location = new System.Drawing.Point(200, 342);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(133, 54);
            this.btnModificarPedido.TabIndex = 18;
            this.btnModificarPedido.Text = "Factura";
            this.btnModificarPedido.UseVisualStyleBackColor = false;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnModificarPedido_Click);
            // 
            // btnInsertarPedido
            // 
            this.btnInsertarPedido.BackColor = System.Drawing.Color.Peru;
            this.btnInsertarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarPedido.Location = new System.Drawing.Point(30, 342);
            this.btnInsertarPedido.Name = "btnInsertarPedido";
            this.btnInsertarPedido.Size = new System.Drawing.Size(133, 54);
            this.btnInsertarPedido.TabIndex = 17;
            this.btnInsertarPedido.Text = "Insertar Venta";
            this.btnInsertarPedido.UseVisualStyleBackColor = false;
            this.btnInsertarPedido.Click += new System.EventHandler(this.btnInsertarPedido_Click);
            // 
            // Menu_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.btnInsertarPedido);
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

