using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* 
             -----Verificar que tengas los últimos cambios antes de realizar tu lógica o formulario

             ----Realizas tu cambios y lo subes preguntando  que estas a punto de subir proyecto 
             
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManVehiculos());
        }
    }
}
