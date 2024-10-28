using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logCliente
    {
        #region Singleton
        //Patron Singleton
        //Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente(); //Privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion Singleton

        #region Metodos

        ///Listado de Clientes

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        ///Inserta
        public bool InsertarCliente(entCliente Cli)
        {
            return datCliente.Instancia.InsertarCliente(Cli);
        }
        //Edita
        public bool EditarCliente(entCliente Cli)
        {
           return datCliente.Instancia.EditarCliente(Cli);
        }
        //Deshabilita
        public void DeshabilitarCliente(entCliente Cli)
        {
            datCliente.Instancia.DeshabilitarCliente(Cli);
        }

        //Informacion Cliente por ID
        public entCliente InformacionClienteID(int idCliente)
        {
            return datCliente.Instancia.InformacionClienteID(idCliente);
        }
        //Informacion Nombre y Ruc
        public entCliente ObtenerNombre_RUC(int idCliente)
        {
            return datCliente.Instancia.ObtenerNombre_RUC(idCliente);
        }
        #endregion Metodos
    }
}
