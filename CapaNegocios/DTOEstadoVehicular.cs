using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
 public  class DTOEstadoVehicular
    {
        private int _IdEstadoVehicular;
        private String _EstadoVehicular;

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

        public string EstadoVehicular
        {
            get
            {
                return _EstadoVehicular;
            }

            set
            {
                _EstadoVehicular = value;
            }
        }
    }
}
