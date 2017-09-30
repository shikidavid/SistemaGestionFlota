using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Seguridad
    {
        Conexion con = new Conexion();
        int estado;
        public int BackUp(string path)
        {
            string query = "backup database GestionFlota to disk='" + path + "'" + " with init,stats = 10";

            con.Conectar();

            SqlCommand cmd = new SqlCommand(query,con.Obtenerconexion());
            estado = cmd.ExecuteNonQuery();
            con.Conectar();

            return estado;
            
        }
    }
}
