using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
  public   class DtoOrigenDestino
    {
        private int _IdOrigenDestino;
        private String _Origen;
        private String _AbreO;
        private String _Destino;
        private String _AbreD;
        private string _Observacion;
        private String _Concatenacion;
        private string _Estado;
        private string _Ruta;
        private int _Kilometraje;

        public int IdOrigenDestino
        {
            get
            {
                return _IdOrigenDestino;
            }

            set
            {
                _IdOrigenDestino = value;
            }
        }

        public string Origen
        {
            get
            {
                return _Origen;
            }

            set
            {
                _Origen = value;
            }
        }

        public string AbreO
        {
            get
            {
                return _AbreO;
            }

            set
            {
                _AbreO = value;
            }
        }

        public string Destino
        {
            get
            {
                return _Destino;
            }

            set
            {
                _Destino = value;
            }
        }

        public string AbreD
        {
            get
            {
                return _AbreD;
            }

            set
            {
                _AbreD = value;
            }
        }

        public String Observacion
        {
            get
            {
                return _Observacion;
            }

            set
            {
                _Observacion = value;
            }
        }

        public string Concatenacion
        {
            get
            {
                return _Concatenacion;
            }

            set
            {
                _Concatenacion = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public string Ruta
        {
            get
            {
                return _Ruta;
            }

            set
            {
                _Ruta = value;
            }
        }

        public int Kilometraje
        {
            get
            {
                return _Kilometraje;
            }

            set
            {
                _Kilometraje = value;
            }
        }
    }
}
