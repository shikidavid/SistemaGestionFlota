using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTORelleno
    {
        private int _IdRelleno;
        private int _IdTipoVehiculo;
        private int _IdOrigenDestino;
        private String _Lugar1;
        private String _Lugar2;

        public int IdRelleno
        {
            get
            {
                return _IdRelleno;
            }

            set
            {
                _IdRelleno = value;
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

        public string Lugar1
        {
            get
            {
                return _Lugar1;
            }

            set
            {
                _Lugar1 = value;
            }
        }

        public string Lugar2
        {
            get
            {
                return _Lugar2;
            }

            set
            {
                _Lugar2 = value;
            }
        }
    }
}
