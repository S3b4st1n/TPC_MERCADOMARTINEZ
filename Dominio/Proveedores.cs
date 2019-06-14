using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Proveedores")]
    public class Proveedores: Persona
    {
        [Key]
        public int Proveedoresid { get; set; }
    }
}
