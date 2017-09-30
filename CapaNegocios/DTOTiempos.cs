using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTOTiempos
    {
        private int _IdOrigenDestino;
        private int _IdEstadoTiempo;
        private String _Tiempo;
        private bool _estado;
        private DateTime _Fecha;

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

        public int IdEstadoTiempo
        {
            get
            {
                return _IdEstadoTiempo;
            }

            set
            {
                _IdEstadoTiempo = value;
            }
        }

        public String Tiempo
        {
            get
            {
                return _Tiempo;
            }

            set
            {
                _Tiempo = value;
            }
        }

        public bool Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public DateTime Fecha
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
    }
}
