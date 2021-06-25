using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlos.Reservaciones
{
    class Reservacion
    {
        private Conexion conexion;
        private string idReservacion;
        private string idCliente;
        private string idMesa;
        private DateTime fecha;
        private string hora;
        private MySqlException error;

        public Reservacion()
        {
            idReservacion = "";
            idCliente = "";
            idMesa = "";
            fecha = DateTime.Today;
            hora = "";
            conexion = new Conexion();
        }

        public Reservacion(string i, string n, string c , DateTime f,string h)
        {

            idReservacion = i;
            idCliente = n;
            idMesa = c;
            fecha = f;
            hora = h;
            conexion = new Conexion();
        }

        public Boolean Guardar()
        {
            if (conexion.IUD(string.Format("INSERT INTO reservacion (idCliente,idMesa,fecha,hora) VALUES ('{0}','{1}','{2}','{3}');", idCliente, idMesa, fecha.ToString("yyyy-MM-dd"), hora)))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }

        public string Idreservacion
        {
            get
            {
                return idReservacion;
            }
            set
            {
                idReservacion = value;
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

        public string IdMesa
        {
            get
            {
                return idMesa;
            }
            set
            {
                idMesa = value;
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
                fecha = value.Date;
            }
        }

        public String Hora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }

        public MySqlException Error
        {
            get { return error; }
        }



    }

}
