using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_id;
        private string usu_nombreUsuario;
        private string usu_contraseña;
        private string usu_apellidoNombre;
        private string rol_codigo;

        public string Rol_codigo
        {
            get { return rol_codigo; }
            set { rol_codigo = value; }
        }

        public string Usu_apellidoNombre
        {
            get { return usu_apellidoNombre; }
            set { usu_apellidoNombre = value; }
        }

        public string Usu_contraseña
        {
            get { return usu_contraseña; }
            set { usu_contraseña = value; }
        }

        public string Usu_nombreUsuario
        {
            get { return usu_nombreUsuario; }
            set { usu_nombreUsuario = value; }
        }

        public int Usu_id
        {
            get { return usu_id; }
            set { usu_id = value; }
        }
        public Usuario(string username, string password, string rolCodigo)
        {
            Usu_nombreUsuario = username;
            Usu_contraseña = password;
            Rol_codigo = rolCodigo;
        }

        public Usuario()
        {
            // TODO: Complete member initialization
        }
    }
}
