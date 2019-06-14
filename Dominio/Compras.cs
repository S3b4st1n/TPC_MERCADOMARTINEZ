using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Compras")]
    public class Compras : Actividad
    {
        [Key]
        public int CompraId { get; set; }

        public int ArticulosId { get; set; }
        public List<Articulos> Articulos { get; set; } // tiene articulos


        public Proveedores Proveedores { get; set; }
        public int ProveedoresId { get; set; } // la orden de compra es 1 por proveedor

        public int estado { get; set; } // 0=pendiente, 1=recibido, 2=cancelado
        public int MontoTotal { get; set; } // Sumatoria de precioBruto de los art.
    }
}
