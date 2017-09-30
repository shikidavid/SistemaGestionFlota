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
    public class Tiempo
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarTiempo(DTOTiempos dto_tiempos)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarTiempos", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = dto_tiempos.IdOrigenDestino;
            cmd.Parameters.Add("@IdEstadoTiempo", SqlDbType.Int).Value = dto_tiempos.IdEstadoTiempo;
            cmd.Parameters.Add("@Tiempo", SqlDbType.VarChar).Value = dto_tiempos.Tiempo;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int LiberarTiempoOrigenDestino(int OrigenDestino, int EstadoTiempo)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_LiberarTiempoOrigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = OrigenDestino;
            cmd.Parameters.Add("@IdEstadoTiempo", SqlDbType.Int).Value = EstadoTiempo;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarTiempos()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarTiempos", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarOrigenDestino(int OrigenDestino)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarTiempoXOrigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = OrigenDestino;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarExistencia(int OrigenDestino, int EstadoTiempo)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarTiempoXID", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = OrigenDestino;
            cmd.Parameters.Add("@IdEstadoTiempo", SqlDbType.Int).Value = EstadoTiempo;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
