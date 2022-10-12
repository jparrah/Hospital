using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Medico
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [ForeignKey(nameof(IdConsulta))]
        [Required]
        public string IdConsulta { get; set; }
        [Required]
        
        public string Nombre { get; set; }
        [Required]
        
        public string PrimerApellido { get; set; }
        [Required]

        public string SegundoApellido { get; set; }
        [Required]
        
        public string Especialidad { get; set; }
        [Required]
        

        public string Email { get; set; }
        [Required]
        
        public string  Telefono { get; set; }



    }
}
