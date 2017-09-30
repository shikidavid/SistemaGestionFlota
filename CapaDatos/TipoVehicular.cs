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
    public class TipoVehicular
    {
        Conexion con = new Conexion();
        int estado;


        public int GuardarTipoVehicular(DTOTipoVehicular TipoVehicular_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarTipoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TipoVehicular", SqlDbType.VarChar).Value = TipoVehicular_dto.TipoVehicular;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = TipoVehicular_dto.Descripcion;
            
            cmd.Parameters.Add("@IdSubTipoVehicular", SqlDbType.Int).Value = TipoVehicular_dto.IdSubTipoVehicular;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarTipoVehicular(DTOTipoVehicular TipoVehicular_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarTipoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = TipoVehicular_dto.IdTipoVehiculo;
            cmd.Parameters.Add("@TipoVehicular", SqlDbType.VarChar).Value = TipoVehicular_dto.TipoVehicular;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = TipoVehicular_dto.Descripcion;
            
            cmd.Parameters.Add("@IdSubTipoVehicular", SqlDbType.Int).Value = TipoVehicular_dto.IdSubTipoVehicular;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarSubTipoVehicular()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarSubTipoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarTipoVehicular()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarTipoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarTipoVehicular(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarTipoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TipoVehicular", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
