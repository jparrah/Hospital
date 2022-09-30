using Hospital.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Hospital
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {

        }
        public DbSet<Hospitall> Hospital { get; set; }
        public DbSet<Consulta> Consulta { get; set; }

        public DbSet<Medico> Medico { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Consulta_Paciente> ConsultaPacientes { get; set; }
    }
}
