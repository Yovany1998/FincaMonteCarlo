using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlos
{

    class IniciarSecion
    {
        private string idUsuario;
        private string usuario;
        private string password;
        private string rol;
        private Conexion conexion;

        public IniciarSecion()
        {
            idUsuario = "";
            usuario = "";
            password = "";
            rol = "";
            conexion = new Conexion();
        }

        public IniciarSecion(string id, string user, string pass, string puesto)
        {
            id =  idUsuario ;
            user = usuario;
            pass = password;
            puesto = rol;
            conexion = new Conexion();
        }

        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        ///<summary>
        ///L O G I N 
        /// </summary>
        /// 

        public IniciarSecion BucarUsuario(string NameUsuario)
        {
            IniciarSecion user = new IniciarSecion();


            DataTable Tabla = conexion.consulta(string.Format("SELECT * FROM usuarios WHERE Usuario='{0}';", NameUsuario));

            if (Tabla.Rows.Count > 0)
            {

                user.idUsuario = Tabla.Rows[0][0].ToString();
                user.usuario = Tabla.Rows[0][1].ToString();
                user.password = Tabla.Rows[0][2].ToString();
                user.rol = Tabla.Rows[0][3].ToString();


            }
            return user;

        }
    }
}
