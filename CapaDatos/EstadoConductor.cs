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
    public class EstadoConductor
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarEstadoConductor(DTOEstadoConductor EstadoConductor_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarEstadoConductor", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EstadoConductor", SqlDbType.VarChar).Value = EstadoConductor_dto.EstadoConductor;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarEstadoConductor(DTOEstadoConductor EstadoConductor_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarEstadoConductor", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdEstadoconductor", SqlDbType.Int).Value = EstadoConductor_dto.IdEstadoconductor;
            cmd.Parameters.Add("@EstadoConductor", SqlDbType.VarChar).Value = EstadoConductor_dto.EstadoConductor;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostarEstadoConductor()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarEstadoConductor", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarEstadoConductor(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarEstadoConductor", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EstadoConductor", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
