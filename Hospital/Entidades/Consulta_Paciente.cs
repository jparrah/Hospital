using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Consulta_Paciente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Id_Consulta { get; set; }
        [Required]
        public int Id_Paciente { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Tratamiento { get; set; }
        [Required]
        public DateTime FechaCitaInicial { get; set; }
        [Required]
        public bool Inicial { get; set; }
        [Required]
        public DateTime FechaCitaProxima { get; set; }






    }
}
