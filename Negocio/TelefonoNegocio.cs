using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;



namespace Negocio
{

    public class TelefonoNegocio
    {
        public int Telefonoid { get; set; }
        public string numeroCasa { get; set; }
        public string numeroCelular { get; set; }

        //Devuelve telefono por id caso de no encontrarlo devuelve id en -1 y numeros en null
        public void GetTelefonobyID(int telefonoid)
        {
             TelefonoDTO teldto = new TelefonoDTO();

            teldto=teldto.GetTelefono(telefonoid);
            if (teldto != null)
            {
                this.Telefonoid = teldto.Telefonoid;
                this.numeroCasa = teldto.numeroCasa;
                this.numeroCelular = teldto.numeroCelular;
            }
            else
            {
                this.Telefonoid = -1;
                this.numeroCasa = null;
                this.numeroCelular = null;
            }
           
        }

        public bool deleteTelefono()
        {
            //valido que el telefono no sea NULL o numeros vacios
            if (this.Telefonoid != -1 && this.numeroCasa != null && this.numeroCelular != null
                && (this.numeroCasa != "" || this.numeroCelular != ""))
            {
                TelefonoDTO teldto = new TelefonoDTO();
                teldto=teldto.GetTelefono(this.Telefonoid);
                return teldto.DeshabilitarTelefono(false);
            }
            return false;
        }

        public int addTelefono()
        {
            //valido que el telefono no sea NULL o numeros vacios
            if (this.Telefonoid != -1 && this.numeroCasa != null &&  this.numeroCelular != null
                &&  (this.numeroCasa != "" || this.numeroCelular != "") )
            {
                TelefonoDTO teldto = new TelefonoDTO();
                teldto.numeroCasa = this.numeroCasa;
                teldto.numeroCelular = this.numeroCelular;
                return teldto.addTelefono();
            }
            return Telefonoid;
        }

        public bool ModifyTelefono()
        {
            //valido que el telefono no sea NULL o numeros vacios
            if (this.Telefonoid != -1 && this.numeroCasa != null && this.numeroCelular != null
                && (this.numeroCasa != "" || this.numeroCelular != ""))
            {
                TelefonoDTO teldto = new TelefonoDTO();
                teldto.Telefonoid = this.Telefonoid;
                teldto.numeroCasa = this.numeroCasa;
                teldto.numeroCelular = this.numeroCelular;
                return teldto.ModifyTelefono();
            }
            return false;
        }
    }
}
