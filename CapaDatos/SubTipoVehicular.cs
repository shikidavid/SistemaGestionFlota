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
   public  class SubTipoVehicular
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarSubTipoVehicular(DTOSubTipoVehicular SubTipoVehicular_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarSubTipoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SubTipoVehicular", SqlDbType.VarChar).Value = SubTipoVehicular_dto.SubTipoVehicular;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = SubTipoVehicular_dto.Descripcion;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarSubTipoVehicular(DTOSubTipoVehicular SubTipoVehicular_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarSubTipoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdSubTipoVehicular", SqlDbType.Int).Value = SubTipoVehicular_dto.IdSubTipoVehicular;
            cmd.Parameters.Add("@SubTipoVehicular", SqlDbType.VarChar).Value = SubTipoVehicular_dto.SubTipoVehicular;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = SubTipoVehicular_dto.Descripcion;
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

        public DataTable MostrarSubTipoVehicularGrilla()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarSubTipoVehicularGrilla", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarSubTipoVehicular(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarSubTipoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SubTipoVehicular", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
