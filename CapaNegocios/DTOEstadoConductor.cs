using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOEstadoConductor
    {
        private int _IdEstadoconductor;
        private String _EstadoConductor;

        public int IdEstadoconductor
        {
            get
            {
                return _IdEstadoconductor;
            }

            set
            {
                _IdEstadoconductor = value;
            }
        }

        public string EstadoConductor
        {
            get
            {
                return _EstadoConductor;
            }

            set
            {
                _EstadoConductor = value;
            }
        }
    }
}
