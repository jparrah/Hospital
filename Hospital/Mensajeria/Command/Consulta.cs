using Hospital.Entidades;
using MediatR;
using static Hospital.Mensajeria.Command.Medico;
using static Hospital.Mensajeria.Command.SeguimientoPacientes;

namespace Hospital.Mensajeria.Command
{
    public class Consulta
    {
        public record RegistarConsultaRequest(
                                    string Id,
                                    string Nombre,
                                    IEnumerable<RegistarSeguimientoPacienteRequest>Seguimientos,
                                    IEnumerable<RegistrarMedicoRequest> Medicos):IRequest<bool>;
        public record ModificarConsultaRequest(
                                    string Id,
                                    string Nombre,
                                    IEnumerable<RegistarSeguimientoPacienteRequest> Seguimientos,
                                    IEnumerable<RegistrarMedicoRequest> Medicos) :IRequest<bool>;
    }
}
