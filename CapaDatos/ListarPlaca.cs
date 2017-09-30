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

    public class ListarPlaca
    {
        Conexion con = new Conexion();
        int estado;

        public DataTable MostrarListaPlaca(String placa)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarListaPlaca", con.Obtenerconexion());
            cmd.Parameters.Add("@Placa", SqlDbType.VarChar).Value = placa;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
        public DataTable MostrarListaPlacaTodo()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarListaPlacaTodo", con.Obtenerconexion());

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

    }
}
