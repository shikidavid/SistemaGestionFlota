using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOAsignacionCombustible
    {
        private int _IdAsignacionCombustible;
        private int _IdUnidadVehicular;
        private int _IdConductor;
        private int _IdTipoConductor;
        private DateTime _FechaAsignacion;
        private bool _Estado;

        public int IdAsignacionCombustible
        {
            get
            {
                return _IdAsignacionCombustible;
            }

            set
            {
                _IdAsignacionCombustible = value;
            }
        }

        public int IdUnidadVehicular
        {
            get
            {
                return _IdUnidadVehicular;
            }

            set
            {
                _IdUnidadVehicular = value;
            }
        }

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

        public int IdTipoConductor
        {
            get
            {
                return _IdTipoConductor;
            }

            set
            {
                _IdTipoConductor = value;
            }
        }

        public DateTime FechaAsignacion
        {
            get
            {
                return _FechaAsignacion;
            }

            set
            {
                _FechaAsignacion = value;
            }
        }

        public bool Estado
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
    }
}
