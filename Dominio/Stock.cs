using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Stock")]
    public class Stock
    {
        [Key]
        public int StockId { get; set; }
        public int stockMinimo { get; set; }
        public int stock { get; set; }
        public Articulos Articulos { get; set; }
        public int ArticulosId { get; set; }
    }
}
