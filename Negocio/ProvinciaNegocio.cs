using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
    public class ProvinciaNegocio
    {
        public int Provinciaid { get; set; }
        public string nombre { get; set; }


        public void GetProvinciabyID(int id)
        {
            List<ProvinciaDTO> provdto = new List<ProvinciaDTO>();

            ProvinciaDTO objProvincia = new ProvinciaDTO();
            provdto = objProvincia.GetProvincia();

            if (provdto != null)
            {
                foreach (var foo in provdto)
                {
                    if (id == foo.Provinciaid)
                    {
                        this.Provinciaid = foo.Provinciaid;
                        this.nombre = foo.nombre;
                    }
                }
            }
            else
            {
                this.Provinciaid = -1;
                this.nombre = null;
            }
        }

        //Devuelvo todas las provincias
        public List<ProvinciaNegocio> GetProvincias()
        {
            List<ProvinciaDTO> provdto = new List<ProvinciaDTO>();

            ProvinciaDTO objProvincia = new ProvinciaDTO();
            provdto = objProvincia.GetProvincia();

            List<ProvinciaNegocio> provretorno = new List<ProvinciaNegocio>();

            if (provdto != null)
            {
                provretorno = provdto.Select(s => new ProvinciaNegocio
                {
                    Provinciaid = s.Provinciaid,
                    nombre = s.nombre
                }).ToList();
                
                return provretorno;
            }
            else
            {
                this.Provinciaid = -1;
                this.nombre = null;
                provretorno.Add(this);
            }
            return null;
        }
    }
}
