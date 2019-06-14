using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Actividad")]
    public class Actividad
    {
        [Key]
        public int ActividadId { get; set; }
        [Required]
        [MaxLength(25)]
        public string Fecha { get; set; }

        public int Usuarioid { get; set; }
        public Usuario Usuario { get; set; }
        
        
    }
}
