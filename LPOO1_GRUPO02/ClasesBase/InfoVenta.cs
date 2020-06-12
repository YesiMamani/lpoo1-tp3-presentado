using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class InfoVenta
    {
        private int cantidadVentas;
        private int cantidadVentasAnuladas;
        private decimal importeTotalVentas;

        public int CantidadVentas
        {
            get { return cantidadVentas; }
            set { cantidadVentas = value; }
        }

        public int CantidadVentasAnuladas
        {
            get { return cantidadVentasAnuladas; }
            set { cantidadVentasAnuladas = value; }
        }

        public decimal ImporteTotalVentas
        {
            get { return importeTotalVentas; }
            set {importeTotalVentas = value; }
        }
    }
}