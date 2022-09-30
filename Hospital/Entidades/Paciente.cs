using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Paciente
    {

        public Paciente()
        {
            consultas = new HashSet<Consulta>();
        }


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
        public int Edad { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Sexo { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Telefono { get; set; }
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Direccion { get; set; }

        public virtual ICollection<Consulta> consultas { get; set; }    
    }
}
