using AutoMapper;
using MediatR;
using static Hospital.Mensajeria.Queries.Paciente;

namespace Hospital.Handlers.QueriesHandlers
{
    public class PacienteHandler : IRequestHandler<ListarPacientesRequest, IEnumerable<ListarPacientesResponse>>,
                                 IRequestHandler<ObtenerPacienteRequest, ObtenerPacienteResponse>
    {
        private readonly IMapper _mapper;
        private readonly AplicationDbContext _context;
        public PacienteHandler(IMapper mapper, AplicationDbContext context)
        {
            _mapper=mapper;
            _context=context;
        }
        public async Task<IEnumerable<ListarPacientesResponse>> Handle(ListarPacientesRequest request, CancellationToken cancellationToken)
        {
            var pacientes = _context.Paciente.ToList();
            var pacientesResponse = new List<ListarPacientesResponse>();

            foreach (var item in pacientes)
            {
                var xx = _mapper.Map<ListarPacientesResponse>(item);
                pacientesResponse.Add(xx);

            }
            return pacientesResponse.AsEnumerable();
        }

        public async Task<ObtenerPacienteResponse> Handle(ObtenerPacienteRequest request, CancellationToken cancellationToken)
        {
            var paciente = _context.Paciente.Where(x => x.Id == request.Id).FirstOrDefault();
            return _mapper.Map<ObtenerPacienteResponse>(paciente);
        }
    }
}
