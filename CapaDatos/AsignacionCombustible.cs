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
    public class AsignacionCombustible
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarAsignacion(DTOAsignacionCombustible asignacion_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarAsignacionCombustible", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;            
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.VarChar).Value = asignacion_dto.IdUnidadVehicular;
            cmd.Parameters.Add("@IdConductor", SqlDbType.VarChar).Value = asignacion_dto.IdConductor;
            cmd.Parameters.Add("@IdTipoConductor", SqlDbType.VarChar).Value = asignacion_dto.IdTipoConductor;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int LiberarUnidad(DTOAsignacionCombustible asignacion_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_liberarAsignacionCombustible", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.VarChar).Value = asignacion_dto.IdUnidadVehicular;            
            cmd.Parameters.Add("@IdConductor", SqlDbType.VarChar).Value = asignacion_dto.IdConductor;            
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable BuscarPlaca(int valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarAsignacionXVehiculo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idunidadvehicular", SqlDbType.Int).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarId()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ObtenerIdAsignacion", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarExistencia(int conductor, int vehiculo)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarAsignacionXID", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdConductor", SqlDbType.Int).Value = conductor;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = vehiculo;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public int LiberarConductor(int conductor, int vehiculo)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_LiberarConductor", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.VarChar).Value = vehiculo;
            cmd.Parameters.Add("@IdConductor", SqlDbType.VarChar).Value = conductor;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }
            
    }
}
