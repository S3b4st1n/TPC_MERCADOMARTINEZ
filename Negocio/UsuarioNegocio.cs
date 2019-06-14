using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;
namespace Negocio
{
    public class UsuarioNegocio : PersonaNegocio
    {
        public int Usuarioid { get; set; }
        public string clave { get; set; }

        public UsuarioNegocio()
        {
            direccionNegocio = new DireccionNegocio();
            telefonoNegocio = new TelefonoNegocio();
        }


        public bool delete()
        {
            UsuarioDTO usrdto = new UsuarioDTO();
            usrdto.nombre = this.nombre;
            usrdto.Apellido = this.Apellido;
            usrdto.clave = this.clave;
            usrdto.Descripcion = this.Descripcion;
            usrdto.Documento = this.Documento;
            usrdto.tipoDocumento = 1;
            usrdto.direccion.Calle = this.direccionNegocio.Calle;
            usrdto.direccion.Altura = this.direccionNegocio.Altura;
            usrdto.direccion.Provinciaid = this.direccionNegocio.provincianegocio.Provinciaid;
            usrdto.direccion.Localidadid = this.direccionNegocio.localidadNegocio.Localidadid;
            usrdto.telefono.numeroCasa = this.telefonoNegocio.numeroCasa;
            usrdto.telefono.numeroCelular = this.telefonoNegocio.numeroCelular;
            return usrdto.Deshabilitar(true);
        }

        private UsuarioNegocio(UsuarioNegocio usr)
        {
            this.Usuarioid = usr.Usuarioid;
            this.nombre = usr.nombre;
            this.Apellido = usr.Apellido;
            this.clave = usr.clave;
            this.Descripcion = usr.Descripcion;
            this.Documento = usr.Documento;
            this.tipoDocumento = usr.tipoDocumento;
            this.telefonoNegocio = usr.telefonoNegocio;
            this.direccionNegocio = usr.direccionNegocio;
        }

        public List<UsuarioNegocio> GetAll()
        {
            telefonoNegocio = new TelefonoNegocio();
            direccionNegocio = new DireccionNegocio();
            List<UsuarioDTO> userdto = new List<UsuarioDTO>();

            UsuarioDTO objuser = new UsuarioDTO();
            userdto = objuser.GetUsers();

            List<UsuarioNegocio> usrReturn = new List<UsuarioNegocio>(); 

            if (userdto != null)
            {
                foreach (var foo in userdto)
                {
                    this.Usuarioid = foo.Usuarioid;
                    this.nombre = foo.nombre;
                    this.Apellido = foo.Apellido;
                    this.clave = foo.clave;
                    this.Descripcion = foo.Descripcion;
                    this.Documento = foo.Documento;
                    this.tipoDocumento = foo.tipoDocumento;
                    this.telefonoNegocio.GetTelefonobyID(foo.TelefonoId);
                    this.direccionNegocio.GetDireccionbyId(foo.Direccionid);
                    usrReturn.Add(new UsuarioNegocio(this));
                    Console.WriteLine("Usuario Cargado " + this.Usuarioid.ToString());                   
                }
                return usrReturn;
            }
            else
            {
                return null;
            }
            
        }

        public void GetUserComplete(int idUsuario)
        {
            UsuarioDTO usrdto = new UsuarioDTO();
            usrdto.GetUser(idUsuario);
            this.nombre = usrdto.nombre;
            this.Apellido = usrdto.Apellido;
            this.clave = usrdto.clave;
            this.Descripcion = usrdto.Descripcion;
            this.Documento = usrdto.Documento;
            this.tipoDocumento = usrdto.tipoDocumento;
            this.telefonoNegocio.GetTelefonobyID(usrdto.TelefonoId);
            this.direccionNegocio.GetDireccionbyId(usrdto.Direccionid);
        }

        public int Add()
        {
            UsuarioDTO usrdto = new UsuarioDTO();
            usrdto.nombre = this.nombre;
            usrdto.Apellido = this.Apellido;
            usrdto.clave = this.clave;
            usrdto.Descripcion = this.Descripcion;
            usrdto.Documento = this.Documento;
            usrdto.tipoDocumento = 1;
            usrdto.direccion.Calle = this.direccionNegocio.Calle;
            usrdto.direccion.Altura = this.direccionNegocio.Altura;
            usrdto.direccion.Provinciaid = this.direccionNegocio.provincianegocio.Provinciaid;
            usrdto.direccion.Localidadid = this.direccionNegocio.localidadNegocio.Localidadid;
            usrdto.telefono.numeroCasa = this.telefonoNegocio.numeroCasa;
            usrdto.telefono.numeroCelular = this.telefonoNegocio.numeroCelular;
            return usrdto.addUsuario();
        }

        public bool Modify()
        {
            throw new NotImplementedException();
        }
    }
}
