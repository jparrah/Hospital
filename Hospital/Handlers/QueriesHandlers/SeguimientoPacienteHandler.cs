using MediatR;
using static Hospital.Mensajeria.Queries.SeguimientoPacientes;

namespace Hospital.Handlers.QueriesHandlers
{
    public class SeguimientoPacienteHandler :
                    IRequestHandler<ListarSeguimientoPacientesRequest, IEnumerable<ListarSeguimientoPacientesResponse>>,
                    IRequestHandler<ObtenerSeguimientoPacienteRequest,ObtenerSeguimientoPacienteResponse>
    {
        public Task<IEnumerable<ListarSeguimientoPacientesResponse>> Handle(ListarSeguimientoPacientesRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ObtenerSeguimientoPacienteResponse> Handle(ObtenerSeguimientoPacienteRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
