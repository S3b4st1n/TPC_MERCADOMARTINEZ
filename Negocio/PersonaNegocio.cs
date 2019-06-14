using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PersonaNegocio
    {
        public string nombre { get; set; } // nombre 
        public string Apellido { get; set; } // apellido
        public string Descripcion { get; set; } // Descripcion
        public int tipoDocumento { get; set; } // 1 - Cuit 2 - DNI 
        public string Documento { get; set; } // puede set cuit y dni dependiento de tipodocumento
        public TelefonoNegocio telefonoNegocio { get; set; }
        public int TelefonoID{get; set;}
        public DireccionNegocio direccionNegocio { get; set; }
        public int DireccionID { get; set; }
    }
}
