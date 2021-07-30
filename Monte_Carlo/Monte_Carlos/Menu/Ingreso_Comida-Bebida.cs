using System;
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
        MonteCarlo Variables = new MonteCarlo();
        long idComidaBebida = 0;
        bool editar = false;
        int log;

        public Ingreso_Comida()
        {
            InitializeComponent();

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
            
            Limpiar();
            editar = false;
            idComidaBebida = 0;

            CargaDv();

            MessageBox.Show("Informacion guardada!");
            Limpiar();
            
        }
    
        private void CargaDv()
        {
            var tbComidaBebida = from p in Variables.Menu
                                 select new
                                 {
                                     p.IdComidaBebida,
                                     p.Nombre,
                                     p.Precio,
                                     p.Tipo,

                                 };
            dvComida.DataSource = tbComidaBebida.CopyAnonymusToDataTable();
        }

    
    
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cmbTipo.SelectedIndex = cmbTipo.SelectedIndex = cmbTipo.SelectedIndex = -1;
            dvComida.ClearSelection();
        }
    
        private void Ingreso_Comida_Load(object sender, EventArgs e)
        {
            CargaDv();
            dvComida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idComidaBebida = 0;
            Limpiar();
            editar = false;
            log = 1;
        }
        private void dvComida_SelectionChanged(object sender, EventArgs e)
        {

                try
                {
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
            if (log == 1)
            {
                Limpiar();
            }
        
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dvComida_MouseClick(object sender, MouseEventArgs e)
        {
            if (log == 1)
            {
                log = 2;
            }
        }
    }
}
