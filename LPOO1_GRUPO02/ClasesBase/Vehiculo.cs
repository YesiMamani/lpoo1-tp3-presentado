using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Vehiculo
    {
        private string veh_matricula;
        private string veh_marca;
        private int veh_modelo;
        private string veh_linea;
        private string veh_color;
        private int veh_puertas;
        private bool veh_gps;
        private int veh_tipoVehiculo;
        private int veh_claseVehiculo;
        private decimal veh_precio;

        public decimal Veh_precio
        {
            get { return veh_precio; }
            set { veh_precio = value; }
        }

        public int Veh_claseVehiculo
        {
            get { return veh_claseVehiculo; }
            set { veh_claseVehiculo = value; }
        }

        public int Veh_tipoVehiculo
        {
            get { return veh_tipoVehiculo; }
            set { veh_tipoVehiculo = value; }
        }

        public bool Veh_gps
        {
            get { return veh_gps; }
            set { veh_gps = value; }
        }

        public int Veh_puertas
        {
            get { return veh_puertas; }
            set { veh_puertas = value; }
        }

        public string Veh_color
        {
            get { return veh_color; }
            set { veh_color = value; }
        }

        public string Veh_linea
        {
            get { return veh_linea; }
            set { veh_linea = value; }
        }

        public int Veh_modelo
        {
            get { return veh_modelo; }
            set { veh_modelo = value; }
        }

        public string Veh_marca
        {
            get { return veh_marca; }
            set { veh_marca = value; }
        }

        public string Veh_matricula
        {
            get { return veh_matricula; }
            set { veh_matricula = value; }
        }
    }
}
