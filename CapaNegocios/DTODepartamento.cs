using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
   public class DTODepartamento
    {

        private int _IdDepartamento;
        private String _Departamento;

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

        public string Departamento
        {
            get
            {
                return _Departamento;
            }

            set
            {
                _Departamento = value;
            }
        }
    }
}
