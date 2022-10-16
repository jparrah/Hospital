using AutoMapper;
using MediatR;
using static Hospital.Mensajeria.Queries.SeguimientoPacientes;

namespace Hospital.Handlers.QueriesHandlers
{
    public class SeguimientoPacienteHandler :
                    IRequestHandler<ListarSeguimientoPacientesRequest, IEnumerable<ListarSeguimientoPacientesResponse>>,
                    IRequestHandler<ObtenerSeguimientoPacienteRequest,ObtenerSeguimientoPacienteResponse>
    {
        private readonly IMapper _mapper;
        private readonly AplicationDbContext _context;
        public SeguimientoPacienteHandler(IMapper mapper, AplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<IEnumerable<ListarSeguimientoPacientesResponse>> Handle(ListarSeguimientoPacientesRequest request, CancellationToken cancellationToken)
        {
            var seguimientos = _context.Seguimientos.ToList();
            var seguimientosResponse = new List<ListarSeguimientoPacientesResponse>();

            foreach (var item in seguimientos)
            {
                var xx = _mapper.Map<ListarSeguimientoPacientesResponse>(item);
                seguimientosResponse.Add(xx);

            }
            return seguimientosResponse.AsEnumerable();

        }

        public async Task<ObtenerSeguimientoPacienteResponse> Handle(ObtenerSeguimientoPacienteRequest request, CancellationToken cancellationToken)
        {
            var seguimiento = _context.Seguimientos.Where(x => x.Id == request.Id).FirstOrDefault();
            return _mapper.Map<ObtenerSeguimientoPacienteResponse>(seguimiento);
        }
    }
}
