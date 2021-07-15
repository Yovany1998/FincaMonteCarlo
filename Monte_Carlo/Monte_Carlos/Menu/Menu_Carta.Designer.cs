namespace Monte_Carlos.Carta
{
    partial class Menu_Carta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Carta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnVerReservacion = new System.Windows.Forms.Button();
            this.btnInsertarComida = new System.Windows.Forms.Button();
            this.btnModificarReservacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(368, 31);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(0, 0);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(38, 31);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "←";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnVerReservacion
            // 
            this.btnVerReservacion.BackColor = System.Drawing.Color.Peru;
            this.btnVerReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReservacion.Location = new System.Drawing.Point(197, 276);
            this.btnVerReservacion.Name = "btnVerReservacion";
            this.btnVerReservacion.Size = new System.Drawing.Size(133, 54);
            this.btnVerReservacion.TabIndex = 2;
            this.btnVerReservacion.Text = " Ver Menu";
            this.btnVerReservacion.UseVisualStyleBackColor = false;
            // 
            // btnInsertarComida
            // 
            this.btnInsertarComida.BackColor = System.Drawing.Color.Peru;
            this.btnInsertarComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarComida.Location = new System.Drawing.Point(35, 276);
            this.btnInsertarComida.Name = "btnInsertarComida";
            this.btnInsertarComida.Size = new System.Drawing.Size(133, 54);
            this.btnInsertarComida.TabIndex = 0;
            this.btnInsertarComida.Text = "Insertar comida/bebida";
            this.btnInsertarComida.UseVisualStyleBackColor = false;
            this.btnInsertarComida.Click += new System.EventHandler(this.btnInsertarComida_Click);
            // 
            // btnModificarReservacion
            // 
            this.btnModificarReservacion.BackColor = System.Drawing.Color.Peru;
            this.btnModificarReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarReservacion.Location = new System.Drawing.Point(197, 276);
            this.btnModificarReservacion.Name = "btnModificarReservacion";
            this.btnModificarReservacion.Size = new System.Drawing.Size(133, 54);
            this.btnModificarReservacion.TabIndex = 1;
            this.btnModificarReservacion.Text = "Modificar Menu";
            this.btnModificarReservacion.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerReservacion);
            this.Controls.Add(this.btnInsertarComida);
            this.Controls.Add(this.btnModificarReservacion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu_Carta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Carta";
            this.Load += new System.EventHandler(this.Menu_Carta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnVerReservacion;
        private System.Windows.Forms.Button btnInsertarComida;
        private System.Windows.Forms.Button btnModificarReservacion;
        private System.Windows.Forms.Label label1;
    }
}