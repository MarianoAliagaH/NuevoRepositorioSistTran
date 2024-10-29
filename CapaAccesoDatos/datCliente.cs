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
        ///////////////Listado de Clientes
        public List<entCliente> ListarCliente()
        {
            
            List<entCliente> lista = new List<entCliente>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //Singleton
                cmd = new SqlCommand("spListaClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.Id = Convert.ToInt32(dr["Id"]);
                    Cli.RazonSocial = dr["RazonSocial"].ToString();
                    Cli.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Cli);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en datCliente - ListarCliente: " + ex.Message);
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

        ///////////////InsertaCliente
        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar todos los parámetros necesarios
                cmd.Parameters.AddWithValue("@RazonSocial", Cli.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", Cli.RUC);
                cmd.Parameters.AddWithValue("@IdTipoPersona", Cli.IdTipoPersona);
                cmd.Parameters.AddWithValue("@Telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                cmd.Parameters.AddWithValue("@Direccion", Cli.Direccion);
                cmd.Parameters.AddWithValue("@Ubigeo", Cli.Ubigeo);
                cmd.Parameters.AddWithValue("@Estado", Cli.Estado);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("Error en datCliente - InsertarCliente: " + e.Message);
                throw;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }


        ///////////////EditaCliente
        public Boolean EditarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar todos los parámetros necesarios
                cmd.Parameters.AddWithValue("@Id", Cli.Id);
                cmd.Parameters.AddWithValue("@RazonSocial", Cli.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", Cli.RUC);
                cmd.Parameters.AddWithValue("@IdTipoPersona", Cli.IdTipoPersona);
                cmd.Parameters.AddWithValue("@Telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                cmd.Parameters.AddWithValue("@Direccion", Cli.Direccion);
                cmd.Parameters.AddWithValue("@Ubigeo", Cli.Ubigeo);
                cmd.Parameters.AddWithValue("@Estado", Cli.Estado);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en datCliente - EditarCliente, al actualizar cliente: " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return edita;
        }

        ///////////////DeshabilitaCliente
        public Boolean DeshabilitarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        ///////////////Informacion Cliente Por ID
        public entCliente InformacionClienteID(int idCliente)
        {
            SqlCommand cmd = null;
            entCliente cliente = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInformacionClienteID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cliente = new entCliente
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        RazonSocial = dr["RazonSocial"].ToString(),
                        RUC = dr["RUC"].ToString(),
                        IdTipoPersona = Convert.ToInt32(dr["IdTipoPersona"]),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Ubigeo = dr["Ubigeo"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    };
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en datCliente - InformacionClienteID, al obtener el cliente: " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return cliente;
        }

        ///////////////Informacion Nombre y RUC
        public entCliente ObtenerNombre_RUC(int idCliente)
        {
            SqlCommand cmd = null;
            entCliente cliente = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInfoNombre_RUC", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cliente = new entCliente
                    {
                        RUC = dr["RUC"].ToString(),
                        RazonSocial = dr["RazonSocial"].ToString(),
                    };
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, en datCliente-ObtenerNombre_RUC: " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return cliente;
        }
        #endregion metodos

    }
}
