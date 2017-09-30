using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
   public  class DTOConductor
    {

        private int _IdConductor;
        private String _DNI;
        private String _Apellido;
        private String _Nombre;
        private String _Licencia;
        private String _Categoria;
        private String _Clase;
        private DateTime _Fecha_Vencimiento;
        private String _Telefono;
        private String _Telefono2;
        private String _Direccion_Actual;
        private String _Direccion;
        private DateTime _Fecha_Contrato;
        private DateTime _Fecha_Fin;
        private int _IdEstadoconductor;
        private int _IdTipoContrato;
        private int _IdEstadoCivil;
        private int _IdDistrito;

        public int IdConductor
        {
            get
            {
                return _IdConductor;
            }

            set
            {
                _IdConductor = value;
            }
        }

        public string DNI
        {
            get
            {
                return _DNI;
            }

            set
            {
                _DNI = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _Apellido;
            }

            set
            {
                _Apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Licencia
        {
            get
            {
                return _Licencia;
            }

            set
            {
                _Licencia = value;
            }
        }

        public string Categoria
        {
            get
            {
                return _Categoria;
            }

            set
            {
                _Categoria = value;
            }
        }

        public string Clase
        {
            get
            {
                return _Clase;
            }

            set
            {
                _Clase = value;
            }
        }

        public DateTime Fecha_Vencimiento
        {
            get
            {
                return _Fecha_Vencimiento;
            }

            set
            {
                _Fecha_Vencimiento = value;
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

        public string Telefono2
        {
            get
            {
                return _Telefono2;
            }

            set
            {
                _Telefono2 = value;
            }
        }

        public string Direccion_Actual
        {
            get
            {
                return _Direccion_Actual;
            }

            set
            {
                _Direccion_Actual = value;
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

        public DateTime Fecha_Contrato
        {
            get
            {
                return _Fecha_Contrato;
            }

            set
            {
                _Fecha_Contrato = value;
            }
        }

        public DateTime Fecha_Fin
        {
            get
            {
                return _Fecha_Fin;
            }

            set
            {
                _Fecha_Fin = value;
            }
        }

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

        public int IdEstadoCivil
        {
            get
            {
                return _IdEstadoCivil;
            }

            set
            {
                _IdEstadoCivil = value;
            }
        }

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
    }
}
