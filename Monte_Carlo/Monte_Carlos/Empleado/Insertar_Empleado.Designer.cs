namespace Monte_Carlos.Empleado
{
    partial class Insertar_Empleado
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
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvempleado = new System.Windows.Forms.DataGridView();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcargo
            // 
            this.txtcargo.AllowDrop = true;
            this.txtcargo.Location = new System.Drawing.Point(389, 92);
            this.txtcargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcargo.Multiline = true;
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(148, 24);
            this.txtcargo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Edad:";
            // 
            // txtapellido
            // 
            this.txtapellido.AllowDrop = true;
            this.txtapellido.Location = new System.Drawing.Point(139, 135);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(148, 24);
            this.txtapellido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellidos:";
            // 
            // txtnombre
            // 
            this.txtnombre.AllowDrop = true;
            this.txtnombre.Location = new System.Drawing.Point(139, 92);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(148, 24);
            this.txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre:";
            // 
            // dvempleado
            // 
            this.dvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvempleado.Location = new System.Drawing.Point(32, 209);
            this.dvempleado.Margin = new System.Windows.Forms.Padding(2);
            this.dvempleado.Name = "dvempleado";
            this.dvempleado.RowHeadersWidth = 51;
            this.dvempleado.RowTemplate.Height = 24;
            this.dvempleado.Size = new System.Drawing.Size(516, 149);
            this.dvempleado.TabIndex = 31;
            this.dvempleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvempleado_CellContentClick);
            // 
            // txtedad
            // 
            this.txtedad.AllowDrop = true;
            this.txtedad.Location = new System.Drawing.Point(389, 46);
            this.txtedad.Margin = new System.Windows.Forms.Padding(2);
            this.txtedad.Multiline = true;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(148, 23);
            this.txtedad.TabIndex = 3;
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.Color.Peru;
            this.btninsertar.Location = new System.Drawing.Point(429, 135);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(90, 40);
            this.btninsertar.TabIndex = 5;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = false;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtid
            // 
            this.txtid.AllowDrop = true;
            this.txtid.Location = new System.Drawing.Point(139, 45);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(148, 24);
            this.txtid.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Identidad:";
            // 
            // Insertar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 411);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.dvempleado);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insertar_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar_Empleado";
            this.Load += new System.EventHandler(this.Insertar_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvempleado;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
    }
}