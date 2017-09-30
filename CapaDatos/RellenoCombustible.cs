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
    public class RellenoCombustible
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarRelleno(DTORelleno Relleno_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarRellenoCombustible", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = Relleno_dto.IdOrigenDestino;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = Relleno_dto.IdTipoVehiculo;
            cmd.Parameters.Add("@Lugar1", SqlDbType.VarChar).Value = Relleno_dto.Lugar1;
            cmd.Parameters.Add("@Lugar2", SqlDbType.VarChar).Value = Relleno_dto.Lugar2;

            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }
        public int ModificaRellenoCombustible(DTORelleno Relleno_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarRelleno", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdRelleno", SqlDbType.Int).Value = Relleno_dto.IdRelleno;
            cmd.Parameters.Add("@Lugar1", SqlDbType.VarChar).Value = Relleno_dto.Lugar1;
            cmd.Parameters.Add("@Lugar2", SqlDbType.VarChar).Value = Relleno_dto.Lugar2;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = Relleno_dto.IdOrigenDestino;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = Relleno_dto.IdTipoVehiculo;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarRellenoCombustible()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarRelleno", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarRellenoCombustible(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarRelleno", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Valor", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarRellenoCombustibleXTipoVehicularXOrigenDestino(int familia, int origen)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarRellenoCombustibleXTipoVehicularXOrigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = familia;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = origen;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarKilometrajeXorigenDestino(int origendestino)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarKilometrajeXorigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = origendestino;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
