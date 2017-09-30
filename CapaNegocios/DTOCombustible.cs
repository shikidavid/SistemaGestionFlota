using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOCombustible
    {
        private int _IdCombustible;
        private int _IdOrigenDestino;
        private int _IdUnidadVehicular;
        private int _IdEstadoRutaTiempo;
        private double _Cantidad1;
        private double _Cantidad2;
        private double _PesoBalanza;
        private double _Consumo;
        private string _Tiempo;
        private string _Observacion;
        private int _IdEstadoCombustible;
        private int _IdUsuario;

        public int IdCombustible
        {
            get
            {
                return _IdCombustible;
            }

            set
            {
                _IdCombustible = value;
            }
        }

        public int IdOrigenDestino
        {
            get
            {
                return _IdOrigenDestino;
            }

            set
            {
                _IdOrigenDestino = value;
            }
        }

        public int IdUnidadVehicular
        {
            get
            {
                return _IdUnidadVehicular;
            }

            set
            {
                _IdUnidadVehicular = value;
            }
        }

        public int IdEstadoRutaTiempo
        {
            get
            {
                return _IdEstadoRutaTiempo;
            }

            set
            {
                _IdEstadoRutaTiempo = value;
            }
        }

        public double Cantidad1
        {
            get
            {
                return _Cantidad1;
            }

            set
            {
                _Cantidad1 = value;
            }
        }

        public double Cantidad2
        {
            get
            {
                return _Cantidad2;
            }

            set
            {
                _Cantidad2 = value;
            }
        }

        public double PesoBalanza
        {
            get
            {
                return _PesoBalanza;
            }

            set
            {
                _PesoBalanza = value;
            }
        }

        public double Consumo
        {
            get
            {
                return _Consumo;
            }

            set
            {
                _Consumo = value;
            }
        }

        public string Tiempo
        {
            get
            {
                return _Tiempo;
            }

            set
            {
                _Tiempo = value;
            }
        }

        public string Observacion
        {
            get
            {
                return _Observacion;
            }

            set
            {
                _Observacion = value;
            }
        }

        public int IdEstadoCombustible
        {
            get
            {
                return _IdEstadoCombustible;
            }

            set
            {
                _IdEstadoCombustible = value;
            }
        }

        public int IdUsuario
        {
            get
            {
                return _IdUsuario;
            }

            set
            {
                _IdUsuario = value;
            }
        }
    }
}
