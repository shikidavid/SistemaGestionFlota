using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
  public  class DTOUsuario
    {
        private int _IdUsuario;
        private String _Usuario;
        private String _Password;
        private String _Nombre;
        private String _Apellido;
        private String _Direccion;
        private DateTime _FechaNacimiento;
        private String _Sexo;
        private int _IdPerfil;

        public int IdUsuario
        {
            get
            {
                return _IdUsuario;
            }

            set
            {
                _IdUsuario = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
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

        public DateTime FechaNacimiento
        {
            get
            {
                return _FechaNacimiento;
            }

            set
            {
                _FechaNacimiento = value;
            }
        }

        public string Sexo
        {
            get
            {
                return _Sexo;
            }

            set
            {
                _Sexo = value;
            }
        }

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
    }
}
