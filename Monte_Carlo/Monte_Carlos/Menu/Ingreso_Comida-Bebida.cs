﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Carta
{
    public partial class Ingreso_Comida : Form
    {
        Finca_Monte_CarloEntities1 Variables = new Finca_Monte_CarloEntities1();
        long idComidaBebida = 0;
        bool editar = false;
            int contador = 0;

        public Ingreso_Comida()
        {
            InitializeComponent();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Carta ventana = new Menu_Carta();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese el Nombre");
                return;
            }
            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el precio");
                return;
            }
            if (cmbTipo.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Por favor seleccione el tipo");
                return;
            }

            if (editar)
            {
                MessageBox.Show("Modifique");
                var tComidaBebida = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == idComidaBebida);
                tComidaBebida.Nombre = txtNombre.Text;
                tComidaBebida.Precio = Convert.ToDouble(txtPrecio.Text);
                tComidaBebida.Tipo = cmbTipo.SelectedItem.ToString();

                Variables.SaveChanges();
            }
            else
            {
                MessageBox.Show("Guarde");
                Menu tbMenu = new Menu();
                tbMenu.Nombre = txtNombre.Text;
                tbMenu.Precio = Convert.ToDouble(txtPrecio.Text);
                tbMenu.Tipo = Convert.ToString(cmbTipo.SelectedItem.ToString());
                Variables.Menu.Add(tbMenu);
                Variables.SaveChanges();
            }
            
            limpiar();
            editar = false;
            idComidaBebida = 0;

            var tbComidaBebida = from p in Variables.Menu
                            select new
                            {
                                p.IdComidaBebida,
                                p.Nombre,
                                p.Precio,
                                p.Tipo,
                             
                            };
            dvComida.DataSource = tbComidaBebida.CopyAnonymusToDataTable();

            MessageBox.Show("Informacion guardada!");
            limpiar();
            
        }
    

    
    
        private void limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cmbTipo.SelectedIndex = cmbTipo.SelectedIndex = cmbTipo.SelectedIndex = -1;


        }
    
        private void Ingreso_Comida_Load(object sender, EventArgs e)
        {
            var tComidaBebida = from p in Variables.Menu
                           select new
                           {
                               p.IdComidaBebida,
                               p.Nombre,
                               p.Precio,
                               p.Tipo
                           };
    
            dvComida.DataSource = tComidaBebida.CopyAnonymusToDataTable();
            dvComida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idComidaBebida = 0;
            limpiar();
            editar = false;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (cmbTipo.SelectedItem != null)
            //{
              //  MessageBox.Show(cmbTipo.SelectedItem.ToString());
            //}
         
        }

        private void dvComida_SelectionChanged(object sender, EventArgs e)
        {
            contador++;
            if (dvComida.RowCount > 1)
            {
                //  MessageBox.Show("Entre");
                //  int contado = 0;
                // contado = contado + 1;

                try
                {
                    //  MessageBox.Show(Convert.ToString(contado));
                    idComidaBebida = Convert.ToInt64(dvComida.SelectedCells[0].Value);
                    var tComidaBebida = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == idComidaBebida);
                    txtNombre.Text = tComidaBebida.Nombre;
                    txtPrecio.Text = Convert.ToString(tComidaBebida.Precio);
                    cmbTipo.Text = Convert.ToString(tComidaBebida.Tipo);
                  
                    editar = true;

                }
                catch (Exception)
                {

                }
            }
            if (contador == 5)
            {
                limpiar();
                // contador = 0;

            }
            if (contador == 3)
            {
                limpiar();
                contador = 2;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
