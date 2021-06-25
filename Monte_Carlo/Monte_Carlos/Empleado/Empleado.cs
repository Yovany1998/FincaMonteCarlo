using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlos.Empleado
{
    class Empleado
    {
            private Conexion conexion;
            private string idEmpleado;
            private string nombre;
            private string apellido;
            private int    edad;
            private string cargo;
            private MySqlException error;

            public Empleado()
            {
                idEmpleado = "";
                nombre = "";
                apellido = "";
                cargo = "";

                conexion = new Conexion();
            }

            public Empleado(string i, string n, string c, string z)
            {

                idEmpleado = i;
                nombre = n;
                apellido = c;
                cargo = z;
                conexion = new Conexion();
            }

            public Boolean Guardar()
            {
                if (conexion.IUD(string.Format("INSERT INTO empleado (idEmpleado,nombre,apeliido,edad,cargo) VALUES ('{0}','{1}', '{2}', '{3}', '{4}');", idEmpleado, nombre, apellido, edad, cargo)))
                {
                    return true;
                }
                else
                {
                    error = conexion.Error;
                    return false;
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

            public string NombreEmpleado
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

            public string ApellidoEmpleado
            {
                get
                {
                    return apellido;
                }
                set
                {
                    apellido = value;
                }
            }
             public int Edad
             {
                 get
                 {
                    return edad;
                 }
                set
                {
                    edad = value;
                }
             }
            public string Cargo
            {
                get
                {
                return cargo;
                }
                set
                {
                cargo = value;
                }
            }

            public MySqlException Error
            {
                get { return error; }
            }



        
    }
}
