using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
   public class DTOSubTipoVehicular
    {
        private int _IdSubTipoVehicular;
        private String _SubTipoVehicular;
        private String _Descripcion;

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

        public string SubTipoVehicular
        {
            get
            {
                return _SubTipoVehicular;
            }

            set
            {
                _SubTipoVehicular = value;
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
    }
}
