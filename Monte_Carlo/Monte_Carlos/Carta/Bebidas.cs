using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlos.Carta
{
    class Bebidas
    {
        private Conexion conexion;
        private int idBebida;
        private string nombre;
        private double precio;
        private string descripcion;
        private MySqlException error;

        public Bebidas()
        {
            idBebida = 0;
            nombre = "";
            precio = 0.0;
            descripcion = "";

            conexion = new Conexion();
        }

        public Bebidas(string i, double n, string z)
        {

            nombre = i;
            precio = n;
            descripcion = z;
            conexion = new Conexion();
        }

        public Boolean Guardar()
        {
            if (conexion.IUD(string.Format("INSERT INTO bebida (nombre,precio,descripcion) VALUES ('{0}','{1}', '{2}');", nombre, precio, descripcion)))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }



        public string NombreBebida
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public MySqlException Error
        {
            get { return error; }
        }

    }
}
