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
  public  class SeguimientoLlamada
    {
        Conexion con = new Conexion();
        int estado;

        public DataTable MostrarUbicacionLlamada()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarUbicacionLlamada", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarTipoLlamada()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarTipoLlamada", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarEstadoLlamada()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarEstadoLlamada", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarOcurrenciaLlamada()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarOcurrenciaLlamada", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarEstadoViaje()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarEstadoViaje", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
