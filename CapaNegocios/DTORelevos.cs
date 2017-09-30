using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTORelevos
    {
        private int _IdTipoVehiculo;
        private int _IdOrigenDestino;
        private DateTime _fecha;
        private String _Relevo;
        private bool _Estado;

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

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        public string Relevo
        {
            get
            {
                return _Relevo;
            }

            set
            {
                _Relevo = value;
            }
        }

        public bool Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }
    }
}
