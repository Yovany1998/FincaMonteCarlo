using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Monte_Carlos.Venta
{
    class Ventas
    {
        private Conexion conexion;
        private int idVenta;
        private int idFactura;
        private string idCliente;
        private string idEmpleado;
        private DateTime fecha;
        private int idComida;
        private double precio;
        private int cantidades;
        private double total;
        private MySqlException error;


        public Ventas()
        {
            idCliente = "";
            idEmpleado = "";
            fecha = DateTime.Today;
            idComida = 0;
            precio = 0.0;
            cantidades = 0;
            total = 0.0;
            conexion = new Conexion();
        }
        public Ventas(string a, string b, int c, double d, int e, double t)
        {
            idCliente = a;
            idEmpleado = b;
            fecha = DateTime.Today;
            idComida = c;
            precio = d;
            cantidades = e;
            total = t;
            conexion = new Conexion();
        }

        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        public int IdVenta
        {
            get
            {
                return idVenta;
            }
            set
            {
                idVenta = value;
            }
        }
        public int IdFactura
        {
            get
            {
                return idFactura;
            }
            set
            {
                idFactura = value;
            }
        }
        public string IdCliente
        {
            get
            {
                return idCliente;
            }
            set
            {
                idCliente = value;
            }
        }

        public string IdEmpleado
        {
            get
            {
                return idEmpleado;
            }
            set
            {
                idEmpleado = value;
            }
        }


        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
        public int IdComida
        {
            get
            {
                return idComida;
            }
            set
            {
                idComida = value;
            }
        }
        public double Precio
        {
            get
            {
                return precio;

            }
            set
            {
                precio = value;
            }
        }
        public int Cantidades
        {
            get
            {
                return cantidades;
            }
            set
            {
                cantidades = value;
            }
        }


        public MySqlException Error
        {
            get { return error; }
        }

        public Boolean Insertar()
        {

            /*Inserta datos en la tabla de detalle de venta */
            if (conexion.IUD(string.Format("insert into DetalleDeFactura(idVenta,idFactura,idComida,precio,Cantidad,Total) value('{0}','{1}','{2}','{3}','{4}','{5}')", idVenta, idFactura, idComida, precio, cantidades, total)))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }

        public Boolean Venta()
        {
            /*Inserta datos en la tabla de venta */
            if (conexion.IUD(string.Format("insert into Venta(idCliente,idEmpleado) value('{0}','{1}')", idCliente, idEmpleado)))
            {
                IdVenta = Convert.ToInt32(conexion.consulta(string.Format("SELECT MAX(idVenta) from Venta")).Rows[0][0].ToString());
            }
            else
            {
                error = conexion.Error;
            }

            if (conexion.IUD(string.Format("insert into Factura(IdEmpleado,idCliente) value('{0}','{1}')", idEmpleado, idCliente)))
            {
                IdFactura = Convert.ToInt32(conexion.consulta(string.Format("SELECT MAX(IdFactura) from Factura")).Rows[0][0].ToString());
                return true;
            }
            else
            {
                //error = conexion.Error;
                return false;
            }
        }


            public Boolean Eliminar()
            {

                if (conexion.IUD(string.Format("DELETE FROM DetalleDeFactura WHERE idVenta='{0}'", IdVenta)))
                {

                }
                else
                {
                    error = conexion.Error;
                }


                if (conexion.IUD(string.Format("DELETE FROM Venta WHERE idVenta='{0}'", IdVenta)))
                {

                }
                else
                {
                    error = conexion.Error;
                }

                if (conexion.IUD(string.Format("DELETE FROM factura WHERE IdFactura='{0}'", IdFactura)))
                {
                    // MessageBox.Show("La venta ha sido cancelada", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return true;
                }
                else
                {
                    error = conexion.Error;
                    return false;
                }
            }


        }
    }
