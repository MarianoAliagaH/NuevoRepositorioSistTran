using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int idCliente { get; set; }
        public string numeroDocumento { get; set; }
        public string razonSocial { get; set; }
        public int idTipoPersona { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public Boolean activo { get; set; }
        public string sitioWeb { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string ultimaModificacionPor { get; set; }
    }
}
