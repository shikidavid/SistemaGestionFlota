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
   public class Grifo
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarGrifo(DTOGrifos Grifo_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarGrifo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Grifo", SqlDbType.VarChar).Value = Grifo_dto.Grifo;
            cmd.Parameters.Add("@Ruc", SqlDbType.BigInt).Value = Grifo_dto.Ruc;
            cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Grifo_dto.Precio;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Grifo_dto.Telefono;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Grifo_dto.Direccion;
            cmd.Parameters.Add("@Referencia", SqlDbType.VarChar).Value = Grifo_dto.Referencia;
       
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarGrifo(DTOGrifos Grifo_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarGrifo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdGrifos", SqlDbType.Int).Value = Grifo_dto.IdGrifos;
            cmd.Parameters.Add("@Grifo", SqlDbType.VarChar).Value = Grifo_dto.Grifo;
            cmd.Parameters.Add("@Ruc", SqlDbType.Int).Value = Grifo_dto.Ruc;
            cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Grifo_dto.Precio;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Grifo_dto.Telefono;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Grifo_dto.Direccion;
            cmd.Parameters.Add("@Referencia", SqlDbType.VarChar).Value = Grifo_dto.Referencia;
         
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostraGrifo()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarGrifo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarGrifo(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarGrifo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Grifo", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarRuc(double valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarRUCGrifo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ruc", SqlDbType.BigInt).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
