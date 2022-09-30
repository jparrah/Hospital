using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Medico
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Apellidos { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Especialidad { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]

        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string  Telefono { get; set; }



    }
}
