using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
   public class DTOTipoContrato
    {
        private int _IdTipoContrato;
        private String _TipoContrato;

        public int IdTipoContrato
        {
            get
            {
                return _IdTipoContrato;
            }

            set
            {
                _IdTipoContrato = value;
            }
        }

        public string TipoContrato
        {
            get
            {
                return _TipoContrato;
            }

            set
            {
                _TipoContrato = value;
            }
        }
    }
}
