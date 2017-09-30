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
    public class EstadoCivil
    {
        Conexion con = new Conexion();
        int estado;

        //Guardar
        public int GuardarEstadoCivil(DTOEstadoCivil EstadoCivil_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarEstadoCivil", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EstadoCivil", SqlDbType.VarChar).Value = EstadoCivil_dto.EstadoCivil;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        //Modificar
        public int ModificarEstadoCivil(DTOEstadoCivil EstadoCivil_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarEstadoCivil", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdEstadocivil", SqlDbType.Int).Value = EstadoCivil_dto.IdEstadocivil;
            cmd.Parameters.Add("@EstadoCivil", SqlDbType.VarChar).Value = EstadoCivil_dto.EstadoCivil;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        //Mostrar
        public DataTable MostrarEstadoCivil()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarEstadoCivil", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        //Buscar
        public DataTable BuscarEstadoCivil(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarEstadoCivil", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EstadoCivil", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
