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
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public virtual ICollection<Seguimientos> Seguimientos { get; set; }


    }
}
