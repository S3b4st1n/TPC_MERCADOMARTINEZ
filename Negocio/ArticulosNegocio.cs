using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class ArticulosNegocio
    {
        public int Articulosid { get; set; } // codigo PLU de art
        public string Descripcion { get; set; } // descripcion del art
        public string precioBruto { get; set; } // PrecioBruto importe compra 
        public string precioNeto { get; set; } // PrecioNeto=PrecioBruto+(PrecioBruto*procentajeGanancia/100) importe venta
        public long porcentajeGanancia { get; set; } // Porcentaje para sacar el importe de venta
        public Marca Marca { get; set; } // marca 1 x art
        public int MarcaId { get; set; }
        public Departamento Departamento { get; set; } // dep 1 x art        
        public Proveedor Proveedores { get; set; }
        public List<Compras> Compras { get; set; }
        public List<Venta> Ventas { get; set; }
        public bool estado { get; set; }



        public List<ArticulosNegocio> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Modify()
        {
            throw new NotImplementedException();
        }

        public int Add()
        {
            throw new NotImplementedException();
        }
    }
}
