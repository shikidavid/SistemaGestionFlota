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
  public  class Provincia
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarProvincia(DTOProvincia Provincia_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarProvincia", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = Provincia_dto.Provincia;
            cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = Provincia_dto.IdDepartamento;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarProvincia(DTOProvincia Provincia_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarProvincia", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdProvincia", SqlDbType.Int).Value = Provincia_dto.IdProvincia;
            cmd.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = Provincia_dto.Provincia;
            cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = Provincia_dto.IdDepartamento;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarDepartamento()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarDepartamento", con.Obtenerconexion());
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

        public DataTable BuscarProvincia(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarProvincia", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Provincia", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarProvinciaXDepartamento(int departamento)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarProvinciaXDepartamento", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdDepartamento", SqlDbType.VarChar).Value = departamento;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
