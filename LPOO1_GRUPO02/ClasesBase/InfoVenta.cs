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
        private decimal importeTotalVentasConfirmadas;
        private decimal importeTotalVentasAnuladas;

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

        public decimal ImporteTotalVentasConfirmadas
        {
            get { return importeTotalVentasConfirmadas; }
            set {importeTotalVentasConfirmadas = value; }
        }

        public decimal ImporteTotalVentasAnuladas
        {
            get { return importeTotalVentasAnuladas; }
            set { importeTotalVentasAnuladas = value; }
        }
    }
}