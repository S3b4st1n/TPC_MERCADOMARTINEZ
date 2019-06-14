using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
    public class LocalidadNegocio
    {
        public int Localidadid { get; set; }
        public string Descripcion { get; set; }


        public List<LocalidadNegocio> GetLocalidadesByProvincia(int provinciaid)
        {
            List<LocalidadDTO> lol = new List<LocalidadDTO>();

            LocalidadDTO objlocalidad = new LocalidadDTO();
            lol = objlocalidad.GetLoalidadbyprovinciaID(provinciaid);

            List<LocalidadNegocio> lolRetorno = new List<LocalidadNegocio>(); 

            if (lol != null)
            {
                lolRetorno = lol.Select(s => new LocalidadNegocio
                {
                    Localidadid = s.Localidadid,
                    Descripcion = s.Descripcion
                }).ToList();

                return lolRetorno;
            }
            else
            {
                this.Localidadid = -1;
                this.Descripcion = null;
                lolRetorno.Add(this);
            }
            return null;
        }

        public void GetlocalidadbyID(int idlocalidad)
        {
            List<LocalidadDTO> loldto = new List<LocalidadDTO>();

            LocalidadDTO objlocalidad = new LocalidadDTO();
            objlocalidad.GetLoalidadbyID(idlocalidad);

            if (objlocalidad != null)
            {
                this.Localidadid = objlocalidad.Localidadid;
                this.Descripcion = objlocalidad.Descripcion;
            }
            else
            {                
                this.Localidadid = -1;
                this.Descripcion = null;
            }
        }

        
    }
}
