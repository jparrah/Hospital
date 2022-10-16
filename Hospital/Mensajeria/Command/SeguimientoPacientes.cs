using MediatR;

namespace Hospital.Mensajeria.Command
{
    public class SeguimientoPacientes
    {
        public record RegistarSeguimientoPacienteRequest(
                                     string Id,
                                     string ConsultaId,
                                     string PacienteId,
                                     string Diagnostico,
                                     string Tratamiento,
                                     string FechaConsultaInicial,
                                     string FechaConsultaProxima,
                                     bool PrimeraVez) : IRequest<bool>;


        public record ModificarSeguimientoPacienteRequest(
                                      string Id,
                                     string ConsultaId,
                                     string PacienteId,
                                     string Diagnostico,
                                     string Tratamiento,
                                     string FechaConsultaInicial,
                                     string FechaConsultaProxima,
                                     bool PrimeraVez) : IRequest<bool>;
        public record EliminarSeguimientoPacienteRequest(string Id) : IRequest<bool>;
    }
}
