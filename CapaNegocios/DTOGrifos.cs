using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
   public class DTOGrifos
    {
        private int _IdGrifos;
        private String _Grifo;
        private double _Ruc;
        private Decimal _Precio;
        private String _Telefono;
        private String _Direccion;
        private String _Referencia;

        public int IdGrifos
        {
            get
            {
                return _IdGrifos;
            }

            set
            {
                _IdGrifos = value;
            }
        }

        public string Grifo
        {
            get
            {
                return _Grifo;
            }

            set
            {
                _Grifo = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return _Precio;
            }

            set
            {
                _Precio = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Referencia
        {
            get
            {
                return _Referencia;
            }

            set
            {
                _Referencia = value;
            }
        }

        public double Ruc
        {
            get
            {
                return _Ruc;
            }

            set
            {
                _Ruc = value;
            }
        }
    }
}
