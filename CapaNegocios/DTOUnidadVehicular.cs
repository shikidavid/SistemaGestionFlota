using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOUnidadVehicular
    {
        private int _IdUnidadVehicular;
        private String _Placa;
        private String _Modelo;
        private int _NEje;
        private int _Año;
        private String _PlacaFurjon;
        private String _NTelefono;
        private int _CapTanque;
        private int _PesoTara;
        private String _Descripcion;
        private int _IdTipoVehiculo;
        private int _IdEstadoVehicular;

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

        public string Placa
        {
            get
            {
                return _Placa;
            }

            set
            {
                _Placa = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _Modelo;
            }

            set
            {
                _Modelo = value;
            }
        }

        public int NEje
        {
            get
            {
                return _NEje;
            }

            set
            {
                _NEje = value;
            }
        }

        public int Año
        {
            get
            {
                return _Año;
            }

            set
            {
                _Año = value;
            }
        }

        public string PlacaFurjon
        {
            get
            {
                return _PlacaFurjon;
            }

            set
            {
                _PlacaFurjon = value;
            }
        }

        public string NTelefono
        {
            get
            {
                return _NTelefono;
            }

            set
            {
                _NTelefono = value;
            }
        }

        public int CapTanque
        {
            get
            {
                return _CapTanque;
            }

            set
            {
                _CapTanque = value;
            }
        }

        public int PesoTara
        {
            get
            {
                return _PesoTara;
            }

            set
            {
                _PesoTara = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public int IdTipoVehiculo
        {
            get
            {
                return _IdTipoVehiculo;
            }

            set
            {
                _IdTipoVehiculo = value;
            }
        }

        public int IdEstadoVehicular
        {
            get
            {
                return _IdEstadoVehicular;
            }

            set
            {
                _IdEstadoVehicular = value;
            }
        }
    }
}
