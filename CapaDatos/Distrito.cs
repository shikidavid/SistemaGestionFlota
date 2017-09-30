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
    public class Distrito
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarDistrito(DTODistrito Distrito_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarDistrito", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Distrito", SqlDbType.VarChar).Value = Distrito_dto.Distrito;
            cmd.Parameters.Add("@IdProvincia", SqlDbType.Int).Value = Distrito_dto.IdProvincia;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarDistrito(DTODistrito Distrito_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarDistrito", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdDistrito", SqlDbType.Int).Value = Distrito_dto.IdDistrito;
            cmd.Parameters.Add("@Distrito", SqlDbType.VarChar).Value = Distrito_dto.Distrito;
            cmd.Parameters.Add("@IdProvincia", SqlDbType.Int).Value = Distrito_dto.IdProvincia;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarDistrito()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarDistrito", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarProvincia()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarProvincia", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarDistrito(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarDistrito", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Distrito", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarDistritoXProvincia(int provincia)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarDistritoXProvincia", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdProvincia", SqlDbType.VarChar).Value = provincia;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
