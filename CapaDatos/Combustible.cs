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

        public string ModificarCombustible(DTOCombustible dto, int piloto, int copiloto)
        {
            Conexion con = new Conexion();

            con.Conectar();

            SqlTransaction tr = con.Obtenerconexion().BeginTransaction();
            SqlCommand cmd = new SqlCommand("SP_ModificarCombustible", con.Obtenerconexion(), tr);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCombustible", SqlDbType.Int).Value = dto.IdCombustible;
                cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = dto.IdOrigenDestino;
                cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = dto.IdUnidadVehicular;
                cmd.Parameters.Add("@IdEstadoRutaTiempo", SqlDbType.Int).Value = dto.IdEstadoRutaTiempo;
                cmd.Parameters.Add("@Cantidad1", SqlDbType.Decimal).Value = dto.Cantidad1;
                cmd.Parameters.Add("@Cantidad2", SqlDbType.Decimal).Value = dto.Cantidad2;
                cmd.Parameters.Add("@PesoBalanza", SqlDbType.Decimal).Value = dto.PesoBalanza;
                cmd.Parameters.Add("@Consumo", SqlDbType.Decimal).Value = dto.Consumo;
                cmd.Parameters.Add("@Tiempo", SqlDbType.VarChar).Value = dto.Tiempo;
                cmd.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = dto.Observacion;
                cmd.Parameters.Add("@IdEstadoCombustible", SqlDbType.Int).Value = dto.IdEstadoCombustible;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = dto.IdUsuario;


                cmd.ExecuteNonQuery();

                tr.Commit();
                return "Datos Guardados Exitosamente";
            }
            catch (Exception ex)
            {
                tr.Rollback();
                return ex.Message;
            }
            finally
            {
                con.Conectar();
            }
        }

        public string GuardarCombustible(DTOCombustible dto,int piloto, int copiloto)
        {
            int codigo = 0;
            Conexion con = new Conexion();

            con.Conectar();

            SqlTransaction tr = con.Obtenerconexion().BeginTransaction();
            SqlCommand cmd = new SqlCommand("SP_GuardarCombustible", con.Obtenerconexion(),tr);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_out = cmd.Parameters.Add("@IdCombustible", SqlDbType.Int);
                cmd.Parameters.Add("@IdOrigenDestino", SqlDbType.Int).Value = dto.IdOrigenDestino;
                cmd.Parameters.Add("@IdUnidadVehicular", SqlDbType.Int).Value = dto.IdUnidadVehicular;
                cmd.Parameters.Add("@IdEstadoRutaTiempo", SqlDbType.Int).Value = dto.IdEstadoRutaTiempo;
                cmd.Parameters.Add("@Cantidad1", SqlDbType.Decimal).Value = dto.Cantidad1;
                cmd.Parameters.Add("@Cantidad2", SqlDbType.Decimal).Value = dto.Cantidad2;
                cmd.Parameters.Add("@PesoBalanza", SqlDbType.Decimal).Value = dto.PesoBalanza;
                cmd.Parameters.Add("@Consumo", SqlDbType.Decimal).Value = dto.Consumo;
                cmd.Parameters.Add("@Tiempo", SqlDbType.VarChar).Value = dto.Tiempo;
                cmd.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = dto.Observacion;
                cmd.Parameters.Add("@IdEstadoCombustible", SqlDbType.Int).Value = dto.IdEstadoCombustible;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = dto.IdUsuario;
                p_out.Direction = ParameterDirection.Output;

                cmd.ExecuteScalar();
                codigo = Convert.ToInt32(cmd.Parameters["@IdCombustible"].Value);

                if (piloto != 0)
                {
                    cmd = new SqlCommand("SP_GuardarDetalleCombustible", con.Obtenerconexion(), tr);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@IdCombustible", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@IdConductor", SqlDbType.Int).Value = piloto;
                    cmd.Parameters.Add("@TipoConductor", SqlDbType.VarChar).Value = "Piloto";
                    cmd.ExecuteNonQuery();
                }

                if (copiloto != 0)
                {
                    cmd = new SqlCommand("SP_GuardarDetalleCombustible", con.Obtenerconexion(), tr);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@IdCombustible", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@IdConductor", SqlDbType.Int).Value = copiloto;
                    cmd.Parameters.Add("@TipoConductor", SqlDbType.VarChar).Value = "Copiloto";
                    cmd.ExecuteNonQuery();
                }

                tr.Commit();
                return "Datos Guardados Exitosamente";
            }
            catch (Exception ex)
            {
                tr.Rollback();
                return ex.Message;
            }
            finally
            {
                con.Conectar();
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
