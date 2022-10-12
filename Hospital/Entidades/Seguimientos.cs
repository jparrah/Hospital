using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Entidades
{
    public class Seguimientos
    {

        [Key]
        
        public string Id { get; set; }
        [ForeignKey(nameof(IdConsulta))]

        public string IdConsulta { get; set; }

        [ForeignKey(nameof(IdPaciente))]

        public string IdPaciente { get; set; }

        public string Diagnostico { get; set; }
        
        public string Tratamiento { get; set; }
        
        public string FechaConsultaInicial { get; set; }
        
        public string FechaConsultaProxima { get; set; }
        
        public bool PrimeraVez { get; set; }
        






    }
}
