using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOComprobante
    {
        private int _IdComprobante;
        private String _Comprobante;
        private String _Descripcion;

        public int IdComprobante
        {
            get
            {
                return _IdComprobante;
            }

            set
            {
                _IdComprobante = value;
            }
        }

        public string Comprobante
        {
            get
            {
                return _Comprobante;
            }

            set
            {
                _Comprobante = value;
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
