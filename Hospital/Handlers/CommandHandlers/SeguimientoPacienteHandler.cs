using MediatR;
using static Hospital.Mensajeria.Command.SeguimientoPacientes;

namespace Hospital.Handlers.CommandHandlers
{
    public class SeguimientoPacienteHandler : IRequestHandler<RegistarSeguimientoPacienteRequest, bool>,
                                            IRequestHandler<ModificarSeguimientoPacienteRequest, bool>
    {
        public Task<bool> Handle(RegistarSeguimientoPacienteRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Handle(ModificarSeguimientoPacienteRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
