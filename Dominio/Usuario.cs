using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Usuario")]
    public class Usuario : Persona
    {
        [Key]
        public int Usuarioid { get; set; }
        [Required]
        [MaxLength(50)]
        public string clave { get; set; }
        [Required]
        [MaxLength(50)]
        public string tipo { get; set; }
    }
}
