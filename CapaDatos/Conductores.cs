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
   public  class Conductores
    {
        Conexion con = new Conexion();
        int estado;

        public int GuardarConductores(DTOConductor Conductor_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_GuardarConductor", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = Conductor_dto.DNI;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Conductor_dto.Apellido;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Conductor_dto.Nombre;
            cmd.Parameters.Add("@Licencia", SqlDbType.VarChar).Value = Conductor_dto.Licencia;
            cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = Conductor_dto.Categoria;
            cmd.Parameters.Add("@Clase", SqlDbType.VarChar).Value = Conductor_dto.Clase;
            cmd.Parameters.Add("@Fecha_Vencimiento", SqlDbType.Date).Value = Conductor_dto.Fecha_Vencimiento;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Conductor_dto.Telefono;

            cmd.Parameters.Add("@Telefono2", SqlDbType.VarChar).Value = Conductor_dto.Telefono2;
            cmd.Parameters.Add("@Direccion_Actual", SqlDbType.VarChar).Value = Conductor_dto.Direccion_Actual;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Conductor_dto.Direccion;
            cmd.Parameters.Add("@Fecha_Contrato", SqlDbType.Date).Value = Conductor_dto.Fecha_Contrato;

            cmd.Parameters.Add("@Fecha_Fin", SqlDbType.Date).Value = Conductor_dto.Fecha_Fin;
            cmd.Parameters.Add("@IdEstadoconductor", SqlDbType.Int).Value = Conductor_dto.IdEstadoconductor;
            cmd.Parameters.Add("@IdTipoContrato", SqlDbType.Int).Value = Conductor_dto.IdTipoContrato;

            cmd.Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = Conductor_dto.IdEstadoCivil;
            cmd.Parameters.Add("@IdDistrito", SqlDbType.Int).Value = Conductor_dto.IdDistrito;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public int ModificarConductores(DTOConductor Conductor_dto)
        {
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_ModificarConductores", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdConductor", SqlDbType.Int).Value = Conductor_dto.IdConductor;
            cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = Conductor_dto.DNI;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Conductor_dto.Apellido;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Conductor_dto.Nombre;
            cmd.Parameters.Add("@Licencia", SqlDbType.VarChar).Value = Conductor_dto.Licencia;
            cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = Conductor_dto.Categoria;
            cmd.Parameters.Add("@Clase", SqlDbType.VarChar).Value = Conductor_dto.Clase;
            cmd.Parameters.Add("@Fecha_Vencimiento", SqlDbType.Date).Value = Conductor_dto.Fecha_Vencimiento;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Conductor_dto.Telefono;

            cmd.Parameters.Add("@Telefono2", SqlDbType.VarChar).Value = Conductor_dto.Telefono2;
            cmd.Parameters.Add("@Direccion_Actual", SqlDbType.VarChar).Value = Conductor_dto.Direccion_Actual;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Conductor_dto.Direccion;
            cmd.Parameters.Add("@Fecha_Contrato", SqlDbType.Date).Value = Conductor_dto.Fecha_Contrato;

            cmd.Parameters.Add("@Fecha_Fin", SqlDbType.Date).Value = Conductor_dto.Fecha_Fin;
            cmd.Parameters.Add("@IdEstadoconductor", SqlDbType.Int).Value = Conductor_dto.IdEstadoconductor;
            cmd.Parameters.Add("@IdTipoContrato", SqlDbType.Int).Value = Conductor_dto.IdTipoContrato;

            cmd.Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = Conductor_dto.IdEstadoCivil;
            cmd.Parameters.Add("@IdDistrito", SqlDbType.Int).Value = Conductor_dto.IdDistrito;
            estado = cmd.ExecuteNonQuery();
            con.Conectar();
            return estado;
        }

        public DataTable MostrarConductores()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarConductores", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarConductor(String valor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarConductores", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = valor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarConductorXID(int Conductor)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarConductorXID", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdConductor", SqlDbType.Int).Value = Conductor;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarTipoContrato()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarTipoContrato", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

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

        public DataTable MostrarEstadoConductor()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarEstadoConductor", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarEstadoConductorNoAsignado()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarEstadoConductorNoAsignado", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable MostrarDepartamento()
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_MostrarDepartamento", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }

        public DataTable BuscarDNI(string dni)
        {
            DataTable dt = new DataTable();
            con.Conectar();
            SqlCommand cmd = new SqlCommand("SP_BuscarDNI", con.Obtenerconexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = dni;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Conectar();
            return dt;
        }
    }
}
