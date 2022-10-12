using MediatR;
using static Hospital.Mensajeria.Queries.Paciente;

namespace Hospital.Handlers.QueriesHandlers
{
    public class PacienteHandler : IRequestHandler<ListarPacientesRequest, IEnumerable<ListarPacientesResponse>>,
                                 IRequestHandler<ObtenerPacienteRequest, ObtenerPacienteResponse>
    {
        public Task<IEnumerable<ListarPacientesResponse>> Handle(ListarPacientesRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ObtenerPacienteResponse> Handle(ObtenerPacienteRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
