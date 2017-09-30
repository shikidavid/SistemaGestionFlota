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
    public class Relevo
    {
        Conexion con = new Conexion();
        int estado;

        public DataTable BuscarRelevo(int TipoVehiculo, int OrigenDestino)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarRelevo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = TipoVehiculo;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = OrigenDestino;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarRelevo(int TipoVehiculo)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarRelevoXTipoVehiculo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = TipoVehiculo;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarRelevoExistencia(int TipoVehiculo, int OrigenDestino, string relevo)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarRelevoExistencia", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = TipoVehiculo;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = OrigenDestino;
            cmd.Parameters.Add("@Relevo", SqlDbType.VarChar).Value = relevo;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public int GuardarRelevo(DTORelevos relevo_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarRelevo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = relevo_dto.IdTipoVehiculo;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = relevo_dto.IdOrigenDestino;
            cmd.Parameters.Add("@Relevo", SqlDbType.VarChar).Value = relevo_dto.Relevo;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int LiberarRelevo(DTORelevos relevo_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_LiberarRelevo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = relevo_dto.IdTipoVehiculo;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = relevo_dto.IdOrigenDestino;
            cmd.Parameters.Add("@Relevo", SqlDbType.VarChar).Value = relevo_dto.Relevo;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable BuscarRelevoXPlacaXOrigen(int placa, int origen)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarRelevoXPlacaXOrigen", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = placa;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = origen;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
