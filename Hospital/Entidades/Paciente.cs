using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Paciente
    {

        public Paciente()
        {
            Seguimientos = new HashSet<Seguimientos>();

        }
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public char Sexo { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Direccion { get; set; }

        public virtual ICollection<Seguimientos> Seguimientos { get; set; }


    }
}
