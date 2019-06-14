using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Departamento")]
    public class Departamento
    {
        [Key]
        public int Departamentoid { get; set; }//codigo de departamento asignado por la BD
        [Required]
        [MaxLength(100)]
        public string descripcion { get; set; } // descripcion de departamento
    }
}
