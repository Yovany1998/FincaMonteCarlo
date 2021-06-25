using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlos.Cliente
{
    class Cliente
    {
        private Conexion conexion;
        private string idCliente;
        private string nombreCliente;
        private string apellidoCliente;
        private MySqlException error;

        public Cliente()
        {
            idCliente = "";
            nombreCliente = "";
            apellidoCliente = "";
            conexion = new Conexion();
        }

        public Cliente(string i, string n, string c)
        {
            
            idCliente = i;
            nombreCliente = n;
            apellidoCliente = c;
          
            conexion = new Conexion();
        }

        public Boolean Guardar()
        {
            if (conexion.IUD(string.Format("INSERT INTO cliente (idCliente,nombre,apellido) VALUES ('{0}','{1}', '{2}');", idCliente, nombreCliente, apellidoCliente)))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
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

        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }
            set
            {
                nombreCliente = value;
            }
        }

        public string ApellidoCliente
        {
            get
            {
                return apellidoCliente;
            }
            set
            {
                apellidoCliente = value;
            }
        }

        public MySqlException Error
        {
            get { return error; }
        }



    }
}
