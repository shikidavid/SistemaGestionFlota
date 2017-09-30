using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOPerfil
    {
        private int _IdPerfil;
        private String _Perfil;

        public int IdPerfil
        {
            get
            {
                return _IdPerfil;
            }

            set
            {
                _IdPerfil = value;
            }
        }

        public string Perfil
        {
            get
            {
                return _Perfil;
            }

            set
            {
                _Perfil = value;
            }
        }
    }
}
