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
  public  class Usuario
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarUsuario(DTOUsuario Usuario_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarUsuario", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario_dto.Usuario;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Usuario_dto.Password;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Usuario_dto.Nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Usuario_dto.Apellido;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Usuario_dto.Direccion;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = Usuario_dto.FechaNacimiento;
            cmd.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = Usuario_dto.Sexo;
            cmd.Parameters.Add("@IdPerfil", SqlDbType.Int).Value = Usuario_dto.IdPerfil;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarUsuario(DTOUsuario Usuario_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarUsuario", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = Usuario_dto.IdUsuario;
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario_dto.Usuario;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Usuario_dto.Password;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Usuario_dto.Nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Usuario_dto.Apellido;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Usuario_dto.Direccion;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = Usuario_dto.FechaNacimiento;
            cmd.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = Usuario_dto.Sexo;
            cmd.Parameters.Add("@IdPerfil", SqlDbType.Int).Value = Usuario_dto.IdPerfil;
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


        public DataTable MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarUsuario", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarUsuario(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarUsuario", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable Login(String usuario, String Password)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_Login", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public String Encriptar(String cadena)
        {
            String Resultado = String.Empty;
            Byte[] conversion = System.Text.Encoding.Unicode.GetBytes(cadena);
            Resultado = Convert.ToBase64String(conversion);
            return Resultado;
        }

        public String Desencriptar(String cadena)
        {
            String Resultado = String.Empty;
            Byte[] conversion = Convert.FromBase64String(cadena);
            Resultado = System.Text.Encoding.Unicode.GetString(conversion);
            return Resultado;
        }
    }
}
