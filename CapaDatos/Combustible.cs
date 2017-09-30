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
  public  class Combustible
    {
        Conexion con = new Conexion();
        int estado;


        public DataTable MostrarPlacaCombustible()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarCombustible", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarPlacaCombustible(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarPlacaCombustible", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Placa", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarEstadoRutaTiempo()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarEstadoRutaTiempo", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public string GuardarCombustible(DTOCombustible dto,int piloto, int copiloto)
        {
            int codigo = 0;
            Conexion con1 = new Conexion();
            Conexion con2 = new Conexion();
            Conexion con3 = new Conexion();

            con1.Conectar();
            con2.Conectar();
            con3.Conectar();

            SqlTransaction tr = con1.Obtenerconexion().BeginTransaction();
            SqlCommand cmd1 = new SqlCommand("SP_GuardarCombustible", con1.Obtenerconexion(),tr);
            


            try
            {

                

                cmd1.CommandType = CommandType.StoredProcedure;
                SqlParameter p_out = cmd1.Parameters.Add("@IdCombustible", SqlDbType.Int);
                cmd1.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = dto.IdOrigenDestino;
                cmd1.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = dto.IdUnidadVehicular;
                cmd1.Parameters.Add("@IdEstadoRutaTiempo", SqlDbType.Int).Value = dto.IdEstadoRutaTiempo;
                cmd1.Parameters.Add("@Cantidad1", SqlDbType.Decimal).Value = dto.Cantidad1;
                cmd1.Parameters.Add("@Cantidad2", SqlDbType.Decimal).Value = dto.Cantidad2;
                cmd1.Parameters.Add("@PesoBalanza", SqlDbType.Decimal).Value = dto.PesoBalanza;
                cmd1.Parameters.Add("@Consumo", SqlDbType.Decimal).Value = dto.Consumo;
                cmd1.Parameters.Add("@Tiempo", SqlDbType.VarChar).Value = dto.Tiempo;
                cmd1.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = dto.Observacion;
                cmd1.Parameters.Add("@IdEstadoCombustible", SqlDbType.Int).Value = dto.IdEstadoCombustible;
                cmd1.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = dto.IdUsuario;
                p_out.Direction = ParameterDirection.Output;

                cmd1.ExecuteScalar();
                codigo = Convert.ToInt32(cmd1.Parameters["@IdCombustible"].Value);

                tr.Commit();
            
                if (piloto != 0)
                {
                    tr = con2.Obtenerconexion().BeginTransaction();
                    SqlCommand cmd2 = new SqlCommand("SP_GuardarDetalleCombustible", con2.Obtenerconexion(), tr);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@IdCombustible", SqlDbType.Int).Value = codigo;
                    cmd2.Parameters.Add("@IdConductor", SqlDbType.Int).Value = piloto;
                    cmd2.Parameters.Add("@TipoConductor", SqlDbType.VarChar).Value = "Piloto";
                    cmd2.ExecuteNonQuery();
                    tr.Commit();
                }

                if (copiloto != 0)
                {
                    tr = con3.Obtenerconexion().BeginTransaction();
                    SqlCommand cmd3 = new SqlCommand("SP_GuardarDetalleCombustible", con3.Obtenerconexion(), tr);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.Add("@IdCombustible", SqlDbType.Int).Value = codigo;
                    cmd3.Parameters.Add("@IdConductor", SqlDbType.Int).Value = copiloto;
                    cmd3.Parameters.Add("@TipoConductor", SqlDbType.VarChar).Value = "Copiloto";
                    cmd3.ExecuteNonQuery();
                    tr.Commit();  
                }

                
                con1.Conectar();
                return "0";
            }
            catch (Exception ex)
            {
                tr.Rollback();
                tr.Rollback();
                tr.Rollback();
                return ex.Message;
            }
        }

        public DataTable MostrarRegistroCombustibleXUnidad(int UnidadVehicular)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarRegistroCombustibleXUnidad", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = UnidadVehicular;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarConductorXCombustible(int combustible)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarConductorXCombustible", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdCombustible", SqlDbType.Int).Value = combustible;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
