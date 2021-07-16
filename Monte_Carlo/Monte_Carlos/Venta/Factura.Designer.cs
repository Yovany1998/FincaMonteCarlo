namespace Monte_Carlos.Venta
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.dvFactura = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Btndetalle = new System.Windows.Forms.Button();
            this.DateTimes = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dvFactura
            // 
            this.dvFactura.BackgroundColor = System.Drawing.Color.Silver;
            this.dvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvFactura.Location = new System.Drawing.Point(15, 161);
            this.dvFactura.Name = "dvFactura";
            this.dvFactura.RowHeadersWidth = 51;
            this.dvFactura.Size = new System.Drawing.Size(522, 238);
            this.dvFactura.TabIndex = 44;
            this.dvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "Ventas a la fecha:";
            // 
            // Btndetalle
            // 
            this.Btndetalle.BackColor = System.Drawing.Color.Peru;
            this.Btndetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndetalle.Location = new System.Drawing.Point(406, 105);
            this.Btndetalle.Name = "Btndetalle";
            this.Btndetalle.Size = new System.Drawing.Size(131, 45);
            this.Btndetalle.TabIndex = 48;
            this.Btndetalle.Text = "Desplegar";
            this.Btndetalle.UseVisualStyleBackColor = false;
            this.Btndetalle.Click += new System.EventHandler(this.Btndetalle_Click);
            // 
            // DateTimes
            // 
            this.DateTimes.Location = new System.Drawing.Point(166, 116);
            this.DateTimes.Name = "DateTimes";
            this.DateTimes.Size = new System.Drawing.Size(200, 20);
            this.DateTimes.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 88);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(46, 78);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 13);
            this.lbTotal.TabIndex = 52;
            this.lbTotal.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Total de Ventas";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateTimes);
            this.Controls.Add(this.Btndetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dvFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btndetalle;
        private System.Windows.Forms.DateTimePicker DateTimes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label2;
    }
}