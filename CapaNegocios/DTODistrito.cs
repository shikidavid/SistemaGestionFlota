using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
  public  class DTODistrito
    {
        private int _IdDistrito;
        private String _Distrito;
        private int _IdProvincia;

        public int IdDistrito
        {
            get
            {
                return _IdDistrito;
            }

            set
            {
                _IdDistrito = value;
            }
        }

        public string Distrito
        {
            get
            {
                return _Distrito;
            }

            set
            {
                _Distrito = value;
            }
        }

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
    }
}
