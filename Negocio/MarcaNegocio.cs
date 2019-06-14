using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
    public class MarcaNegocio
    {

        public MarcaNegocio(MarcaNegocio obj)
        {
            this.Marcaid = obj.Marcaid;
            this.estado = obj.estado;
            this.descripcion = obj.descripcion;
        }

        public MarcaNegocio()
        {
        }

        public int Marcaid { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }


        public void GetbyID(int ID)
        {
            MarcaDTO objdto = new MarcaDTO();

            objdto = objdto.GetMarcaID(ID);
            if (objdto != null)
            {
                this.Marcaid = objdto.Marcaid;
                this.descripcion = objdto.descripcion;
                this.estado = objdto.estado;
            }
            else
            {
                this.Marcaid = -1;
                this.descripcion = null;
                this.estado = false;
            }

        }

        public bool Delete()
        {
            if (this.Marcaid != -1 && this.descripcion != null)
            {
                MarcaDTO objdto = new MarcaDTO();
                objdto = objdto.GetMarcaID(Marcaid);
                return objdto.Deshabilitar(true);
            }
            return false;
        }

        public int Add()
        {
            if (this.descripcion != null && this.estado != true)
            {
                MarcaDTO objdto = new MarcaDTO();
                objdto.estado = this.estado;
                objdto.descripcion = this.descripcion;
                Console.WriteLine("Voy a cargar Marca: " + objdto.descripcion+" "+ objdto.estado.ToString());
                return objdto.Add();
            }
            return -1;
        }

        public bool Modify()
        {
            //valido que el telefono no sea NULL o numeros vacios
            if (this.Marcaid != -1 && this.descripcion != null)
            {
                MarcaDTO objdto = new MarcaDTO();
                objdto.Marcaid = this.Marcaid;
                objdto.estado = this.estado;
                objdto.descripcion = this.descripcion;
                return objdto.Modify();
            }
            return false;
        }



        public List<MarcaNegocio> GetAll()
        {

            List<MarcaDTO> objList = new List<MarcaDTO>();

            MarcaDTO objdto = new MarcaDTO();
            objList = objdto.GetAll();

            List<MarcaNegocio> listreturn = new List<MarcaNegocio>();

            if (objList != null)
            {
                foreach (var foo in objList)
                {
                    this.Marcaid= foo.Marcaid;
                    this.estado = foo.estado;
                    this.descripcion = foo.descripcion;
                    listreturn.Add(new MarcaNegocio(this));
                    Console.WriteLine("DTO Cargando Lista id: " + this.Marcaid.ToString());
                }
                return listreturn;
            }
            else
            {
                return null;
            }

        }

    }
}
