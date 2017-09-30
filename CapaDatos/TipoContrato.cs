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
    public class TipoContrato
    {

        Conexion con = new Conexion();
        int estado;

        public int GuardarTipoContrato(DTOTipoContrato TipoContrato_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarContrato", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TipoContrato", SqlDbType.VarChar).Value = TipoContrato_dto.TipoContrato;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarTipoContrato(DTOTipoContrato TipoContrato_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarTipoContrato", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoContrato", SqlDbType.Int).Value = TipoContrato_dto.IdTipoContrato;
            cmd.Parameters.Add("@TipoContrato", SqlDbType.VarChar).Value = TipoContrato_dto.TipoContrato;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarTipoContrato()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarTipoContrato", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarTipoContrato(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarTipoContrato", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TipoContrato", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
