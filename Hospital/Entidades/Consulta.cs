using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Consulta
    {
        public Consulta()
        {
            pacientes = new HashSet<Paciente>();
            consultaPacientes = new HashSet<Consulta_Paciente>();
        }


        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [Column(TypeName="varchar(100)")]
        public string  Nombre { get; set; }
        [Required]
        public int Id_Medico { get; set; }

        public virtual ICollection<Paciente> pacientes { get; set; }

        public virtual ICollection<Consulta_Paciente> consultaPacientes { get; set; }

    }
}
