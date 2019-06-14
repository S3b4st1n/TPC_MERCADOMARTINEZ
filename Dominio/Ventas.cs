using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Ventas")]
    public class Ventas : Actividad
    {
        [Key]
        public int Ventasid { get; set; } // id unico de venta

        public int ArticulosId { get; set; }
        public ICollection<Articulos> Articulos { get; set; } // tiene articulos

        public int Clientesid { get; set; }
        public Clientes Clientes { get; set; } // la venta es 1 por cliente


        public int MontoTotal { get; set; } // Sumatoria de precioNEto de los art.
    }
}
