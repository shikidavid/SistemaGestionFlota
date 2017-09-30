using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOTipoVehicular
    {
        private int _IdTipoVehiculo;
        private String _TipoVehicular;
        private String _Descripcion;
        private int _IdSubTipoVehicular;

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

        public string TipoVehicular
        {
            get
            {
                return _TipoVehicular;
            }

            set
            {
                _TipoVehicular = value;
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

        public int IdSubTipoVehicular
        {
            get
            {
                return _IdSubTipoVehicular;
            }

            set
            {
                _IdSubTipoVehicular = value;
            }
        }
    }
}
