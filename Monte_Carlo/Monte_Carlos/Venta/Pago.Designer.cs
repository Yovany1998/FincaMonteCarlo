namespace Monte_Carlos.Venta
{
    partial class Pago
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
            this.txtTipoPago = new System.Windows.Forms.TextBox();
            this.BtnGenerarPago = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.Location = new System.Drawing.Point(146, 139);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPago.TabIndex = 0;
            // 
            // BtnGenerarPago
            // 
            this.BtnGenerarPago.Location = new System.Drawing.Point(466, 321);
            this.BtnGenerarPago.Name = "BtnGenerarPago";
            this.BtnGenerarPago.Size = new System.Drawing.Size(161, 50);
            this.BtnGenerarPago.TabIndex = 1;
            this.BtnGenerarPago.Text = "Generar Pago";
            this.BtnGenerarPago.UseVisualStyleBackColor = true;
            this.BtnGenerarPago.Click += new System.EventHandler(this.BtnGenerarPago_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total :";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(605, 146);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(22, 13);
            this.Total.TabIndex = 3;
            this.Total.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de pago :";
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(29, 193);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(617, 107);
            this.dgvVenta.TabIndex = 44;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 393);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGenerarPago);
            this.Controls.Add(this.txtTipoPago);
            this.Name = "Pago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipoPago;
        private System.Windows.Forms.Button BtnGenerarPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvVenta;
    }
}