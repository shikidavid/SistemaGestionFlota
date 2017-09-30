using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
   public class DTOProvincia
    {

        private int _IdProvincia;
        private String _Provincia;
        private int _IdDepartamento;

        public int IdProvincia
        {
            get
            {
                return _IdProvincia;
            }

            set
            {
                _IdProvincia = value;
            }
        }

        public string Provincia
        {
            get
            {
                return _Provincia;
            }

            set
            {
                _Provincia = value;
            }
        }

        public int IdDepartamento
        {
            get
            {
                return _IdDepartamento;
            }

            set
            {
                _IdDepartamento = value;
            }
        }
    }
}
