using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Seguimientos
    {

        [Key]
        public string Id { get; set; }
        public string ConsultaId { get; set; }
        public string PacienteId { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string FechaConsultaInicial { get; set; }
        public string FechaConsultaProxima { get; set; }
        public bool PrimeraVez { get; set; }
        public Consulta consulta  { get; set; }
        public Paciente paciente { get; set; }
        






    }
}
