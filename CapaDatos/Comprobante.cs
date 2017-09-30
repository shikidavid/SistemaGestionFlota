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
    public class Comprobante
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarComprobante(DTOComprobante Comprobante_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarComprobante", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Comprobante", SqlDbType.VarChar).Value = Comprobante_dto.Comprobante;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Comprobante_dto.Descripcion;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarComprobante(DTOComprobante Comprobante_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarComprobante", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdComprobante", SqlDbType.Int).Value = Comprobante_dto.IdComprobante;
            cmd.Parameters.Add("@Comprobante", SqlDbType.VarChar).Value = Comprobante_dto.Comprobante;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Comprobante_dto.Descripcion;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarComprobante()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarComprobante", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarComprobante(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarComprobante", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Comprobante", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
