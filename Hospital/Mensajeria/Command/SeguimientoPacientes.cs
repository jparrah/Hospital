using MediatR;

namespace Hospital.Mensajeria.Command
{
    public class SeguimientoPacientes
    {
        public record RegistarSeguimientoPacienteRequest(
                                     string Id,
                                     string IdConsulta,
                                     string IdPaciente,
                                     string Diagnostico,
                                     string Tratamiento,
                                     string FechaConsultaInicial,
                                     string FechaConsultaProxima,
                                     bool PrimeraVez) : IRequest<bool>;


        public record ModificarSeguimientoPacienteRequest(
                                     string Id,
                                     string IdConsulta,
                                     string IdPaciente,
                                     string Tratamiento,
                                     string FechaCita,
                                     string FechaProximaCita,
                                     bool PrimeraVez) : IRequest<bool>;
    }
}
