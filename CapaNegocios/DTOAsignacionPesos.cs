using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOAsignacionPesos
    {
        private int _IdUnidadVehicular;
        private int _IdOrigenDestino;
        private int _Capacidad;
        private int _Galonaje;
        private String _Fecha;
        private bool _Estado;

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

        public int Capacidad
        {
            get
            {
                return _Capacidad;
            }

            set
            {
                _Capacidad = value;
            }
        }

        public int Galonaje
        {
            get
            {
                return _Galonaje;
            }

            set
            {
                _Galonaje = value;
            }
        }

        public string Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
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
