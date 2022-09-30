using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Hospitall
    {
        public Hospitall()
        {
            consultas = new HashSet<Consulta>();
            medicos = new HashSet<Medico>();
        }


        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Direccion { get; set; }
        
        public virtual ICollection<Consulta> consultas { get; set; }
        public virtual ICollection <Medico> medicos { get; set; }

    }
}
