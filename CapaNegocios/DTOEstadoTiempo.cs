using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOEstadoTiempo
    {
        private int _IdEstadoTiempo;
        private String _EstadoTiempo;

        public int IdEstadoTiempo
        {
            get
            {
                return _IdEstadoTiempo;
            }

            set
            {
                _IdEstadoTiempo = value;
            }
        }

        public string EstadoTiempo
        {
            get
            {
                return _EstadoTiempo;
            }

            set
            {
                _EstadoTiempo = value;
            }
        }
    }
}
