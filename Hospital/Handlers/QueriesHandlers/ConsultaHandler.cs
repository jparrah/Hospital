using MediatR;
using static Hospital.Mensajeria.Queries.Consulta;

namespace Hospital.Handlers.QueriesHandlers
{
    public class ConsultaHandler : IRequestHandler<ListarConsultaRequest, IEnumerable<ListarConsultaResponse>>,
                                 IRequestHandler<ObtenerConsultaRequest, ObtenerConsultaResponse>
    {
        public Task<IEnumerable<ListarConsultaResponse>> Handle(ListarConsultaRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ObtenerConsultaResponse> Handle(ObtenerConsultaRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
