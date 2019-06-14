using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
    public class DepartamentoNegocio
    {
        public int Departamentoid { get; set; }//codigo de departamento asignado por la BD
        public string descripcion { get; set; } // descripcion de departamento
        public bool estado { get; set; }

        public DepartamentoNegocio(DepartamentoNegocio obj)
        {
            this.Departamentoid = obj.Departamentoid;
            this.estado = obj.estado;
            this.descripcion = obj.descripcion;
        }

        public DepartamentoNegocio()
        {
        }

        public void GetbyID(int ID)
        {
            DepartamentoDTO objdto = new DepartamentoDTO();

            objdto = objdto.GetDepartamentoID(ID);
            if (objdto != null)
            {
                this.Departamentoid = objdto.Departamentoid;
                this.descripcion = objdto.descripcion;
                this.estado = objdto.estado;
            }
            else
            {
                this.Departamentoid = -1;
                this.descripcion = null;
                this.estado = false;
            }

        }

        public bool Delete()
        {
            if (this.Departamentoid != -1 && this.descripcion != null)
            {
                DepartamentoDTO objdto = new DepartamentoDTO();
                objdto = objdto.GetDepartamentoID(Departamentoid);
                return objdto.Deshabilitar(true);
            }
            return false;
        }

        public int Add()
        {
            if (this.descripcion != null && this.estado != true)
            {
                DepartamentoDTO objdto = new DepartamentoDTO();
                objdto.estado = this.estado;
                objdto.descripcion = this.descripcion;
                Console.WriteLine("Voy a cargar Marca: " + objdto.descripcion + " " + objdto.estado.ToString());
                return objdto.Add();
            }
            return -1;
        }

        public bool Modify()
        {
            //valido que el telefono no sea NULL o numeros vacios
            if (this.Departamentoid != -1 && this.descripcion != null)
            {
                DepartamentoDTO objdto = new DepartamentoDTO();
                objdto.Departamentoid = this.Departamentoid;
                objdto.estado = this.estado;
                objdto.descripcion = this.descripcion;
                return objdto.Modify();
            }
            return false;
        }



        public List<DepartamentoNegocio> GetAll()
        {

            List<DepartamentoDTO> objList = new List<DepartamentoDTO>();

            DepartamentoDTO objdto = new DepartamentoDTO();
            objList = objdto.GetAll();

            List<DepartamentoNegocio> listreturn = new List<DepartamentoNegocio>();

            if (objList != null)
            {
                foreach (var foo in objList)
                {
                    this.Departamentoid = foo.Departamentoid;
                    this.estado = foo.estado;
                    this.descripcion = foo.descripcion;
                    listreturn.Add(new DepartamentoNegocio(this));
                    Console.WriteLine("DTO Cargando Lista id: " + this.Departamentoid.ToString());
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
