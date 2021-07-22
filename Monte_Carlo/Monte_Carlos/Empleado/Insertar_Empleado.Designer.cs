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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insertar_Empleado));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvEmpleado = new System.Windows.Forms.DataGridView();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnElimicar = new System.Windows.Forms.Button();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Edad:";
            // 
            // txtApellido
            // 
            this.txtApellido.AllowDrop = true;
            this.txtApellido.Location = new System.Drawing.Point(158, 135);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(148, 24);
            this.txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Location = new System.Drawing.Point(158, 92);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre:";
            // 
            // dvEmpleado
            // 
            this.dvEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvEmpleado.Location = new System.Drawing.Point(51, 241);
            this.dvEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.dvEmpleado.Name = "dvEmpleado";
            this.dvEmpleado.RowHeadersWidth = 51;
            this.dvEmpleado.RowTemplate.Height = 24;
            this.dvEmpleado.Size = new System.Drawing.Size(516, 149);
            this.dvEmpleado.TabIndex = 31;
            this.dvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvempleado_CellContentClick);
            // 
            // txtEdad
            // 
            this.txtEdad.AllowDrop = true;
            this.txtEdad.Location = new System.Drawing.Point(408, 46);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(148, 23);
            this.txtEdad.TabIndex = 3;
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.Color.Peru;
            this.btninsertar.Image = ((System.Drawing.Image)(resources.GetObject("btninsertar.Image")));
            this.btninsertar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btninsertar.Location = new System.Drawing.Point(424, 181);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(98, 49);
            this.btninsertar.TabIndex = 5;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = false;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtId
            // 
            this.txtId.AllowDrop = true;
            this.txtId.Location = new System.Drawing.Point(158, 45);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 24);
            this.txtId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Identidad:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Peru;
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(74, 181);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 49);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnElimicar
            // 
            this.btnElimicar.BackColor = System.Drawing.Color.Peru;
            this.btnElimicar.ForeColor = System.Drawing.Color.Black;
            this.btnElimicar.Image = ((System.Drawing.Image)(resources.GetObject("btnElimicar.Image")));
            this.btnElimicar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnElimicar.Location = new System.Drawing.Point(250, 181);
            this.btnElimicar.Name = "btnElimicar";
            this.btnElimicar.Size = new System.Drawing.Size(98, 49);
            this.btnElimicar.TabIndex = 36;
            this.btnElimicar.Text = "Eliminar";
            this.btnElimicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnElimicar.UseVisualStyleBackColor = false;
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Cocina",
            "Aseo",
            "Barra",
            "Caja"});
            this.cmbCargo.Location = new System.Drawing.Point(424, 92);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(121, 21);
            this.cmbCargo.TabIndex = 37;
            // 
            // Insertar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 472);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnElimicar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.dvEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insertar_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar_Empleado";
            this.Load += new System.EventHandler(this.Insertar_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvEmpleado;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnElimicar;
        private System.Windows.Forms.ComboBox cmbCargo;
    }
}