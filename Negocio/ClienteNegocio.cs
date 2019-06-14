using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
    public class ClienteNegocio : PersonaNegocio
    {
        public int Clienteid { get; set; }


        public ClienteNegocio()
        {
            direccionNegocio = new DireccionNegocio();
            telefonoNegocio = new TelefonoNegocio();
        }

        public int Add()
        { 
            ClienteDTO dto = new ClienteDTO();
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
            Console.WriteLine("ADD Cliente " + this.Documento.ToString());
            return dto.addClient();

        }

        private ClienteNegocio(ClienteNegocio usr)
        {
            this.Clienteid = usr.Clienteid;
            this.nombre = usr.nombre;
            this.Apellido = usr.Apellido;            
            this.Descripcion = usr.Descripcion;
            this.Documento = usr.Documento;
            this.tipoDocumento = usr.tipoDocumento;
            this.telefonoNegocio = usr.telefonoNegocio;
            this.direccionNegocio = usr.direccionNegocio;
        }

        public List<ClienteNegocio> GetAll()
        {
            telefonoNegocio = new TelefonoNegocio();
            direccionNegocio = new DireccionNegocio();
            List<ClienteDTO> objlist = new List<ClienteDTO>();

            ClienteDTO objuser = new ClienteDTO();
            objlist = objuser.GetClient();

            List<ClienteNegocio> Return = new List<ClienteNegocio>();

            if (objlist != null)
            {
                foreach (var foo in objlist)
                {
                    this.Clienteid = foo.Clienteid;
                    this.nombre = foo.nombre;
                    this.Apellido = foo.Apellido;                    
                    this.Descripcion = foo.Descripcion;
                    this.Documento = foo.Documento;
                    this.tipoDocumento = foo.tipoDocumento;
                    this.telefonoNegocio.GetTelefonobyID(foo.TelefonoId);
                    this.direccionNegocio.GetDireccionbyId(foo.Direccionid);
                    Return.Add(new ClienteNegocio(this));
                    Console.WriteLine("Usuario Cargado " + this.Clienteid.ToString());
                }
                return Return;
            }
            else
            {
                return null;
            }

        }

        public void GetClientComplete(int id)
        {
            ClienteDTO dto = new ClienteDTO();
            dto.GetClientByID(id);
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
            ClienteDTO dto = new ClienteDTO();
            dto.Clienteid = this.Clienteid;
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
            Console.WriteLine("DELETE Cliente " + this.Documento.ToString());
            return dto.Deshabilitar(true);
        }

        public bool Modify()
        {
            ClienteDTO dto = new ClienteDTO();
            dto.Clienteid = this.Clienteid;
            dto.nombre = this.nombre;
            dto.Apellido = this.Apellido;
            dto.Descripcion = this.Descripcion;
            dto.Documento = this.Documento;
            dto.tipoDocumento = 1;
            dto.Direccionid = this.direccionNegocio.Direccionid;
            dto.direccion.Direccionid = this.direccionNegocio.Direccionid;
            dto.direccion.Calle = this.direccionNegocio.Calle;
            dto.direccion.Altura = this.direccionNegocio.Altura;
            dto.direccion.Provinciaid = this.direccionNegocio.provincianegocio.Provinciaid;
            dto.direccion.Localidadid = this.direccionNegocio.localidadNegocio.Localidadid;
            dto.telefono.Telefonoid = this.telefonoNegocio.Telefonoid;
            dto.telefono.numeroCasa = this.telefonoNegocio.numeroCasa;
            dto.telefono.numeroCelular = this.telefonoNegocio.numeroCelular;
            Console.WriteLine("Modify Cliente " + this.Documento.ToString());
            return dto.Modify();
        }
    }
}
