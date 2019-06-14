using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    // Clase articulos
    [Table("Articulos")]
    public class Articulos
    {
        [Key]
        public int Articulosid { get; set; } // codigo PLU de art
        [Required]
        [MaxLength(100)]
        public string Descripcion{ get; set; } // descripcion del art
        [Required]
        [MaxLength(25)]
        public string precioBruto { get; set; } // PrecioBruto importe compra 
        [Required]
        [MaxLength(25)]
        public string precioNeto { get; set; } // PrecioNeto=PrecioBruto+(PrecioBruto*procentajeGanancia/100) importe venta
        [Required]
        public long porcentajeGanancia { get; set; } // Porcentaje para sacar el importe de venta

        public Marca Marca { get; set; } // marca 1 x art
        public int MarcaId { get; set; }

        public Departamento Departamento { get; set; } // dep 1 x art
        public int DepartamentoId { get; set; }

        public Proveedores Proveedores { get; set; }
        public int ProveedoresId { get; set; }

        public List<Compras> Compras { get; set; }
        public List<Ventas> Ventas { get; set; }

    }
}
