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
   public class UnidadVehicular
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarUnidadVehicular(DTOUnidadVehicular UnidadVehicular_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarUnidad", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Placa", SqlDbType.VarChar).Value = UnidadVehicular_dto.Placa;
            cmd.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = UnidadVehicular_dto.Modelo;
            cmd.Parameters.Add("@NEje", SqlDbType.Int).Value = UnidadVehicular_dto.NEje;
            cmd.Parameters.Add("@Año", SqlDbType.Int).Value = UnidadVehicular_dto.Año;
            cmd.Parameters.Add("@PlacaFurjon", SqlDbType.VarChar).Value = UnidadVehicular_dto.PlacaFurjon;
            cmd.Parameters.Add("@NTelefono", SqlDbType.VarChar).Value = UnidadVehicular_dto.NTelefono;
            cmd.Parameters.Add("@CapTanque", SqlDbType.Int).Value = UnidadVehicular_dto.CapTanque;
            cmd.Parameters.Add("@PesoTara", SqlDbType.Int).Value = UnidadVehicular_dto.PesoTara;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = UnidadVehicular_dto.Descripcion;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = UnidadVehicular_dto.IdTipoVehiculo;
            cmd.Parameters.Add("@IdEstadoVehicular", SqlDbType.Int).Value = UnidadVehicular_dto.IdEstadoVehicular;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarUnidadVehicular(DTOUnidadVehicular UnidadVehicular_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarUnidad", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = UnidadVehicular_dto.IdUnidadVehicular;
            cmd.Parameters.Add("@Placa", SqlDbType.VarChar).Value = UnidadVehicular_dto.Placa;
            cmd.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = UnidadVehicular_dto.Modelo;
            cmd.Parameters.Add("@NEje", SqlDbType.Int).Value = UnidadVehicular_dto.NEje;
            cmd.Parameters.Add("@Año", SqlDbType.Int).Value = UnidadVehicular_dto.Año;
            cmd.Parameters.Add("@PlacaFurjon", SqlDbType.VarChar).Value = UnidadVehicular_dto.PlacaFurjon;
            cmd.Parameters.Add("@NTelefono", SqlDbType.VarChar).Value = UnidadVehicular_dto.NTelefono;
            cmd.Parameters.Add("@CapTanque", SqlDbType.Int).Value = UnidadVehicular_dto.CapTanque;
            cmd.Parameters.Add("@PesoTara", SqlDbType.Int).Value = UnidadVehicular_dto.PesoTara;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = UnidadVehicular_dto.Descripcion;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = UnidadVehicular_dto.IdTipoVehiculo;
            cmd.Parameters.Add("@IdEstadoVehicular", SqlDbType.Int).Value = UnidadVehicular_dto.IdEstadoVehicular;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarEstadoVehicular()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarEstadoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarTipoVehicular()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarTipoVehicular", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarUnidadVehicular()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarUnidad", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarUnidadVehicular(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarUnidad", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Placa", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarUnidadVehicularXFamilia(int familia)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarUnidadVehicularXFamilia", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdTipoVehiculo", SqlDbType.Int).Value = familia;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarUnidadVehicularXPlaca(string placa)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarUnidadVehicularXPlaca", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Placa", SqlDbType.VarChar).Value = placa;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
