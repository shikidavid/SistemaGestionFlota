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
    public class RelevoUnidad
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarRelevoUnidad(DTORelevoUnidad relevo_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarRelevoUnidad", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = relevo_dto.IdUnidadVehicular;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = relevo_dto.IdOrigenDestino;
            cmd.Parameters.Add("@Relevo", SqlDbType.VarChar).Value = relevo_dto.Relevo;
            cmd.Parameters.Add("@Kilometraje", SqlDbType.Decimal).Value = relevo_dto.Kilometraje;
            cmd.Parameters.Add("@Tanqueo", SqlDbType.Decimal).Value = relevo_dto.Tanqueo;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable BuscarRelevoUnidad(int placa, int origen)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarRelevoUnidad", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = placa;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = origen;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public int ModificarRelevoUnidad(DTORelevoUnidad relevo_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarRelevoUnidad", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = relevo_dto.IdUnidadVehicular;
            cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = relevo_dto.IdOrigenDestino;
            cmd.Parameters.Add("@Relevo", SqlDbType.VarChar).Value = relevo_dto.Relevo;
            cmd.Parameters.Add("@Kilometraje", SqlDbType.Decimal).Value = relevo_dto.Kilometraje;
            cmd.Parameters.Add("@Tanqueo", SqlDbType.Decimal).Value = relevo_dto.Tanqueo;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }
    }
}
