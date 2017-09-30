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
   public class Perfil
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarPerfil(DTOPerfil Perfil_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarPerfil", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = Perfil_dto.Perfil;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarPerfil(DTOPerfil Perfil_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarPerfil", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdPerfil", SqlDbType.Int).Value = Perfil_dto.IdPerfil;
            cmd.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = Perfil_dto.Perfil;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarPerfil()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarPerfil", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarPerfil(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarPerfil", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
