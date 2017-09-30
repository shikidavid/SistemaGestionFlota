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
    public class OrigenDestino
    {

        Conexion con = new Conexion();
        int estado;


        public int ModificarOrigenDestino(DtoOrigenDestino OrigenDestino_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarOrigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = OrigenDestino_dto.IdOrigenDestino;
            cmd.Parameters.Add("@Origen", SqlDbType.VarChar).Value = OrigenDestino_dto.Origen;
            cmd.Parameters.Add("@AbreO", SqlDbType.VarChar).Value = OrigenDestino_dto.AbreO;
            cmd.Parameters.Add("@Destino", SqlDbType.VarChar).Value = OrigenDestino_dto.Destino;
            cmd.Parameters.Add("@AbreD", SqlDbType.VarChar).Value = OrigenDestino_dto.AbreD;
            cmd.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = OrigenDestino_dto.Observacion;
            cmd.Parameters.Add("@Concatenacion", SqlDbType.VarChar).Value = OrigenDestino_dto.Concatenacion;
            cmd.Parameters.Add("@Ruta", SqlDbType.VarChar).Value = OrigenDestino_dto.Ruta;
            cmd.Parameters.Add("@Kilometraje", SqlDbType.Int).Value = OrigenDestino_dto.Kilometraje;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int GuardarOrigenDestino(DtoOrigenDestino OrigenDestino_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarOrigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Origen", SqlDbType.VarChar).Value = OrigenDestino_dto.Origen;
            cmd.Parameters.Add("@AbreO", SqlDbType.VarChar).Value = OrigenDestino_dto.AbreO;
            cmd.Parameters.Add("@Destino", SqlDbType.VarChar).Value = OrigenDestino_dto.Destino;
            cmd.Parameters.Add("@AbreD", SqlDbType.VarChar).Value = OrigenDestino_dto.AbreD;
            cmd.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = OrigenDestino_dto.Observacion;
            cmd.Parameters.Add("@Concatenacion", SqlDbType.VarChar).Value = OrigenDestino_dto.Concatenacion;
            cmd.Parameters.Add("@Ruta", SqlDbType.VarChar).Value = OrigenDestino_dto.Ruta;
            cmd.Parameters.Add("@Kilometraje", SqlDbType.Int).Value = OrigenDestino_dto.Kilometraje;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarOrigenDestino()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarOrigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarOrigenDestino(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarOrigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Origen", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarOrigenDestinoXOrigenDestino(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarOrigenDestinoXOrigenXDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Valor", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarOrigenDestino(int origen)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarKilometrajeXorigenDestino", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = origen;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
