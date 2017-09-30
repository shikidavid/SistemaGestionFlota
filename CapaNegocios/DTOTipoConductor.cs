using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
   public class DTOTipoConductor
    {

        private int _IdTipoConductor;
        private String _TipoConductor;

        public int IdTipoConductor
        {
            get
            {
                return _IdTipoConductor;
            }

            set
            {
                _IdTipoConductor = value;
            }
        }

        public string TipoConductor
        {
            get
            {
                return _TipoConductor;
            }

            set
            {
                _TipoConductor = value;
            }
        }
    }
}
