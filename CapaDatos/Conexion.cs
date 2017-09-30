using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Conexion
    {
        String Cadena_Conexion = "Data Source=localhost; Initial Catalog =GestionFlota; uid=sa; pwd=123456";
        //String Cadena_Conexion = "Data Source=ANALISTA-PC; Initial Catalog =GestionFlota; Integrated Security=true";
        SqlConnection cnn;

        public Conexion()
        {
            cnn = new SqlConnection(Cadena_Conexion);
        }

        public string Cadena_Conexion1
        {
            get
            {
                return Cadena_Conexion;
            }

            set
            {
                Cadena_Conexion = value;
            }
        }

        public void Conectar()
        {
            if (cnn != null && cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            else
            {
                cnn.Close();
            }
        }

        public SqlConnection Obtenerconexion()
        {
            return cnn;
        }
    }
}
