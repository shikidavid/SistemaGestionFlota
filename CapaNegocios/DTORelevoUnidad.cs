using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DTORelevoUnidad
    {
        private int _IdUnidadVehicular;
        private int _IdOrigenDestino;
        private string _Relevo;
        private double _Kilometraje;
        private double _Tanqueo;

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

        public string Relevo
        {
            get
            {
                return _Relevo;
            }

            set
            {
                _Relevo = value;
            }
        }

        public double Kilometraje
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

        public double Tanqueo
        {
            get
            {
                return _Tanqueo;
            }

            set
            {
                _Tanqueo = value;
            }
        }
    }
}
