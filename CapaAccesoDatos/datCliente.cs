using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datCliente
    {
        #region Singleton
        //Patron Singleton
        //Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente(); //Privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        ////////////////////Listado de Clientes
        public List<entCliente> ListarCliente()
        {
            
            List<entCliente> lista = new List<entCliente>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //Singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.numeroDocumento = dr["numeroDocumento"].ToString();
                    Cli.razonSocial = dr["razonSocial"].ToString();
                    Cli.idTipoPersona = Convert.ToInt32(dr["idTipoPersona"]);
                    Cli.departamento = dr["departamento"].ToString();
                    Cli.provincia = dr["provincia"].ToString();
                    Cli.distrito = dr["distrito"].ToString();
                    Cli.direccion = dr["direccion"].ToString();
                    Cli.telefono = dr["telefono"].ToString();
                    Cli.correo = dr["correo"].ToString();
                    Cli.activo = Convert.ToBoolean(dr["activo"]);
                    Cli.sitioWeb = dr["sitioWeb"].ToString();
                    Cli.fechaRegistro = Convert.ToDateTime(dr["fechaRegistro"]);
                    Cli.ultimaModificacionPor = dr["ultimaModificacionPor"].ToString();
                    lista.Add(Cli);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los clientes: " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }

        /////////////////////////InsertaCliente
        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeroDocumento", Cli.numeroDocumento);
                cmd.Parameters.AddWithValue("@razonSocial", Cli.razonSocial);
                cmd.Parameters.AddWithValue("@idTipoPersona", Cli.idTipoPersona);
                cmd.Parameters.AddWithValue("@departamento", Cli.departamento);
                cmd.Parameters.AddWithValue("@provincia", Cli.provincia);
                cmd.Parameters.AddWithValue("@distrito", Cli.distrito);
                cmd.Parameters.AddWithValue("@direccion", Cli.direccion);
                cmd.Parameters.AddWithValue("@telefono", Cli.telefono);
                cmd.Parameters.AddWithValue("@correo", Cli.correo);
                cmd.Parameters.AddWithValue("@activo", Cli.activo);
                cmd.Parameters.AddWithValue("@sitioWeb", Cli.sitioWeb);
                cmd.Parameters.AddWithValue("@fechaRegistro", Cli.fechaRegistro);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        #endregion Metodos
    }
}
