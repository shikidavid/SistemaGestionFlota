using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaNegocios;
namespace CapaDatos
{
   public class ListarConductoreActivos
    {
        Conexion con = new Conexion();
        int estado;

        public DataTable MostrarListaConductores(String placa)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarListaConductoresTodo", con.Obtenerconexion());
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = placa;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarConductoresXDNI(String DNI)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarListaConductoresXDNI", con.Obtenerconexion());
            cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = DNI;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarConductoresXApellido(String Apellido)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarListaConductoresTodo", con.Obtenerconexion());
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Apellido;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarListaConductoresTodo()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarListaConductores", con.Obtenerconexion());

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
