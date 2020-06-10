using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Venta
    {
        private int vta_id;
        private string clie_dni;
        private string veh_matricula;
        private int usu_id;
        private DateTime vta_fecha;
        private string vta_formaPago;
        private decimal vta_precioFinal;

        public decimal Vta_precioFinal
        {
            get { return vta_precioFinal; }
            set { vta_precioFinal = value; }
        }

        public string Vta_formaPago
        {
            get { return vta_formaPago; }
            set { vta_formaPago = value; }
        }

        public DateTime Vta_fecha
        {
            get { return vta_fecha; }
            set { vta_fecha = value; }
        }

        public int Usu_id
        {
            get { return usu_id; }
            set { usu_id = value; }
        }

        public string Veh_matricula
        {
            get { return veh_matricula; }
            set { veh_matricula = value; }
        }

        public string Clie_dni
        {
            get { return clie_dni; }
            set { clie_dni = value; }
        }

        public int Vta_id
        {
            get { return vta_id; }
            set { vta_id = value; }
        }
    }
}
