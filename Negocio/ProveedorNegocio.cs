using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
    public class ProveedorNegocio : PersonaNegocio
    {
        public int Proveedorid { get; set; }


        public ProveedorNegocio()
        {
            direccionNegocio = new DireccionNegocio();
            telefonoNegocio = new TelefonoNegocio();
        }

        public int Add()
        {
            ProveedoresDTO dto = new ProveedoresDTO();
            dto.nombre = this.nombre;
            dto.Apellido = this.Apellido;
            dto.Descripcion = this.Descripcion;
            dto.Documento = this.Documento;
            dto.tipoDocumento = 1;
            dto.direccion.Calle = this.direccionNegocio.Calle;
            dto.direccion.Altura = this.direccionNegocio.Altura;
            dto.direccion.Provinciaid = this.direccionNegocio.provincianegocio.Provinciaid;
            dto.direccion.Localidadid = this.direccionNegocio.localidadNegocio.Localidadid;
            dto.telefono.numeroCasa = this.telefonoNegocio.numeroCasa;
            dto.telefono.numeroCelular = this.telefonoNegocio.numeroCelular;
            return dto.Add();

        }

        private ProveedorNegocio(ProveedorNegocio usr)
        {
            this.Proveedorid = usr.Proveedorid;
            this.nombre = usr.nombre;
            this.Apellido = usr.Apellido;
            this.Descripcion = usr.Descripcion;
            this.Documento = usr.Documento;
            this.tipoDocumento = usr.tipoDocumento;
            this.telefonoNegocio = usr.telefonoNegocio;
            this.direccionNegocio = usr.direccionNegocio;
        }

        public List<ProveedorNegocio> GetAll()
        {
            telefonoNegocio = new TelefonoNegocio();
            direccionNegocio = new DireccionNegocio();
            List<ProveedoresDTO> objlist = new List<ProveedoresDTO>();

            ProveedoresDTO objuser = new ProveedoresDTO();
            objlist = objuser.GetAll();

            List<ProveedorNegocio> Return = new List<ProveedorNegocio>();

            if (objlist != null)
            {
                foreach (var foo in objlist)
                {
                    this.Proveedorid = foo.Proveedoresid;
                    this.nombre = foo.nombre;
                    this.Apellido = foo.Apellido;
                    this.Descripcion = foo.Descripcion;
                    this.Documento = foo.Documento;
                    this.tipoDocumento = foo.tipoDocumento;
                    this.telefonoNegocio.GetTelefonobyID(foo.TelefonoId);
                    this.direccionNegocio.GetDireccionbyId(foo.Direccionid);
                    Return.Add(new ProveedorNegocio(this));
                    Console.WriteLine("Usuario Cargado " + this.Proveedorid.ToString());
                }
                return Return;
            }
            else
            {
                return null;
            }

        }

        public void GetProveedorComplete(int id)
        {
            ProveedoresDTO dto = new ProveedoresDTO();
            dto.GetProveedorById(id);
            this.nombre = dto.nombre;
            this.Apellido = dto.Apellido;
            this.Descripcion = dto.Descripcion;
            this.Documento = dto.Documento;
            this.tipoDocumento = dto.tipoDocumento;
            this.telefonoNegocio.GetTelefonobyID(dto.TelefonoId);
            this.direccionNegocio.GetDireccionbyId(dto.Direccionid);
        }

        public bool delete()
        {
            ProveedoresDTO dto = new ProveedoresDTO();
            dto.Proveedoresid = this.Proveedorid;
            dto.nombre = this.nombre;
            dto.Apellido = this.Apellido;
            dto.Descripcion = this.Descripcion;
            dto.Documento = this.Documento;
            dto.tipoDocumento = 1;
            dto.direccion.Calle = this.direccionNegocio.Calle;
            dto.direccion.Altura = this.direccionNegocio.Altura;
            dto.direccion.Provinciaid = this.direccionNegocio.provincianegocio.Provinciaid;
            dto.direccion.Localidadid = this.direccionNegocio.localidadNegocio.Localidadid;
            dto.telefono.numeroCasa = this.telefonoNegocio.numeroCasa;
            dto.telefono.numeroCelular = this.telefonoNegocio.numeroCelular;
            return dto.Deshabilitar(true);
        }

        public bool Modify()
        {
            ProveedoresDTO dto = new ProveedoresDTO();
            dto.Proveedoresid = this.Proveedorid;
            dto.nombre = this.nombre;
            dto.Apellido = this.Apellido;
            dto.Descripcion = this.Descripcion;
            dto.Documento = this.Documento;
            dto.tipoDocumento = 1;
            dto.direccion.Calle = this.direccionNegocio.Calle;
            dto.direccion.Altura = this.direccionNegocio.Altura;
            dto.direccion.Provinciaid = this.direccionNegocio.provincianegocio.Provinciaid;
            dto.direccion.Localidadid = this.direccionNegocio.localidadNegocio.Localidadid;
            dto.telefono.Telefonoid = this.telefonoNegocio.Telefonoid;
            dto.telefono.numeroCasa = this.telefonoNegocio.numeroCasa;
            dto.telefono.numeroCelular = this.telefonoNegocio.numeroCelular;
            return dto.Modify();
        }
    }
}
