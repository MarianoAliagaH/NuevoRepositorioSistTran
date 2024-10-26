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

        ///Listado

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        ///Inserta
        public void InsertarCliente(entCliente Cli)
        {
            datCliente.Instancia.InsertarCliente(Cli);
        }

        #endregion Metodos
    }
}
