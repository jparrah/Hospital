using AutoMapper;
using MediatR;
using static Hospital.Mensajeria.Command.Consulta;
using static Hospital.Mensajeria.Queries.Consulta;

namespace Hospital.Handlers.QueriesHandlers
{
    public class ConsultaHandler : IRequestHandler<ListarConsultaRequest, IEnumerable<ListarConsultaResponse>>,
                                 IRequestHandler<ObtenerConsultaRequest, ObtenerConsultaResponse>
                                 
    {
        private readonly IMapper _mapper;
        private readonly AplicationDbContext _contexto;

        public ConsultaHandler(IMapper mapper, AplicationDbContext contexto)
        {
            _mapper = mapper;
            _contexto = contexto;
        }

        public async Task<IEnumerable<ListarConsultaResponse>> Handle(ListarConsultaRequest request, CancellationToken cancellationToken)
        {
            var consultas = _contexto.Consulta.ToList();
            var consultasResponse = new List<ListarConsultaResponse>();

            foreach (var item in consultas)
            {
                var xx = _mapper.Map<ListarConsultaResponse>(item);
                consultasResponse.Add(xx);

            }
            return consultasResponse.AsEnumerable();
        }

        public async Task<ObtenerConsultaResponse> Handle(ObtenerConsultaRequest request, CancellationToken cancellationToken)
        {
            var consulta = _contexto.Consulta.Where(x => x.Id == request.Id);
               return _mapper.Map<ObtenerConsultaResponse>(consulta);
        }

        
    }
}
