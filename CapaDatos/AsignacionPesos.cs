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
    public class AsignacionPesos
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarPesos(DTOAsignacionPesos asignacion_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarAsignacionPesos", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = asignacion_dto.IdUnidadVehicular;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = asignacion_dto.IdOrigenDestino;
            cmd.Parameters.Add("@Capacidad", SqlDbType.Int).Value = asignacion_dto.Capacidad;
            cmd.Parameters.Add("@Galonaje", SqlDbType.Int).Value = asignacion_dto.Galonaje;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarAsignacionPesos", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarPesosXFamiliaXOrigenDestino(int Familia, int OrigenDestino)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarAsignacionPesosXFamiliaXOrigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = Familia;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = OrigenDestino;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarPesosXPlacaXOrigenDestino(string placa, int OrigenDestino)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarAsignacionPesosXPlacaXOrigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Placa", SqlDbType.VarChar).Value = placa;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = OrigenDestino;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarExistencia(DTOAsignacionPesos dto_asignacion)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarExistenciaAsignacionPesos", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = dto_asignacion.IdUnidadVehicular;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = dto_asignacion.IdOrigenDestino;
            cmd.Parameters.Add("@Capacidad", SqlDbType.Int).Value = dto_asignacion.Capacidad;
            cmd.Parameters.Add("@Galonaje", SqlDbType.Int).Value = dto_asignacion.Galonaje;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public int LiberarAsignacion(DTOAsignacionPesos asignacion_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_LiberarAsignacionPesos", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = asignacion_dto.IdUnidadVehicular;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = asignacion_dto.IdOrigenDestino;
            cmd.Parameters.Add("@Capacidad", SqlDbType.Int).Value = asignacion_dto.Capacidad;
            cmd.Parameters.Add("@Galonaje", SqlDbType.Int).Value = asignacion_dto.Galonaje;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }
    }
}
