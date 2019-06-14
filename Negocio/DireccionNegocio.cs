using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
    public class DireccionNegocio
    {
        public int Direccionid { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public int Piso { get; set; }
        public ProvinciaNegocio provincianegocio { get; set; }
        public LocalidadNegocio localidadNegocio { get; set; }

        public DireccionNegocio()
        {
            provincianegocio = new ProvinciaNegocio();
            localidadNegocio = new LocalidadNegocio();
        }

        public void GetDireccionbyId(int direccionid)
        {
            DireccionDTO direccion = new DireccionDTO();
            direccion= direccion.GetDireccion(direccionid);
            provincianegocio = new ProvinciaNegocio();
            localidadNegocio = new LocalidadNegocio();


            if (direccion != null)
            {
                this.Direccionid = direccion.Direccionid;
                this.Calle = direccion.Calle;
                this.Altura = direccion.Altura;
                this.Piso = direccion.Piso;
                provincianegocio.GetProvinciabyID(direccion.Provinciaid);
                localidadNegocio.GetlocalidadbyID(direccion.Localidadid);
            }
            else
            {
                this.Direccionid = -1;
                this.Calle = null;
                this.Altura = null;
                this.Piso = -1;
                this.provincianegocio.Provinciaid = -1;
                this.provincianegocio.nombre = null;
                this.localidadNegocio.Localidadid = -1;
                this.localidadNegocio.Descripcion = null;
            }
        }
    }
}
