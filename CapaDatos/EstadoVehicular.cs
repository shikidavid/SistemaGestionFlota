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
   public class EstadoVehicular
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarEstadoVehicular(DTOEstadoVehicular EstadoVehicular_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarEstadoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EstadoVehicular", SqlDbType.VarChar).Value = EstadoVehicular_dto.EstadoVehicular;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarEstadoVehicular(DTOEstadoVehicular EstadoVehicular_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarEstadoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdEstadoVehicular", SqlDbType.Int).Value = EstadoVehicular_dto.IdEstadoVehicular;
            cmd.Parameters.Add("@EstadoVehicular", SqlDbType.VarChar).Value = EstadoVehicular_dto.EstadoVehicular;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarEstadoVehicular()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarEstadoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarEstadoVehicularGrilla()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarEstadoVehicularGrilla", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
        public DataTable BuscarEstadoVehicular(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarEstadoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EstadoVehicular", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
