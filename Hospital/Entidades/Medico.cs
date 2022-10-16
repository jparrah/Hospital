using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Medico
    {
        [Key]
        public string Id { get; set; }
        public string ConsultaId { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Especialidad { get; set; }
        public string Email { get; set; }
        public string  Telefono { get; set; }
        public Consulta consulta { get; set; }



    }
}
