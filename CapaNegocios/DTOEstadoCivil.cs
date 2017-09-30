using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOEstadoCivil
    {

        private int _IdEstadocivil;
        private String _EstadoCivil;

        public int IdEstadocivil
        {
            get
            {
                return _IdEstadocivil;
            }

            set
            {
                _IdEstadocivil = value;
            }
        }

        public string EstadoCivil
        {
            get
            {
                return _EstadoCivil;
            }

            set
            {
                _EstadoCivil = value;
            }
        }
    }
}
