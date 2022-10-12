using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Consulta
    {
        public Consulta()
        {
            Medicos= new HashSet<Medico>();
            Seguimientos= new HashSet<Seguimientos>();
        }


        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        
        public string  Nombre { get; set; }
        
        

        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Seguimientos> Seguimientos { get; set; }

        

    }
}
