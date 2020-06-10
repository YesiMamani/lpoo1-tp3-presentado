using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string cli_dni;
        private string cli_nombre;
        private string cli_apellido;
        private string cli_direccion;

        public string Cli_direccion
        {
            get { return cli_direccion; }
            set { cli_direccion = value; }
        }
        private string cli_telefono;

        public string Cli_telefono
        {
            get { return cli_telefono; }
            set { cli_telefono = value; }
        }

        public string Cli_apellido
        {
            get { return cli_apellido; }
            set { cli_apellido = value; }
        }

        public string Cli_nombre
        {
            get { return cli_nombre; }
            set { cli_nombre = value; }
        }

        public string Cli_dni
        {
            get { return cli_dni; }
            set { cli_dni = value; }
        }

    }
}
