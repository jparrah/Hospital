using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Hospital.Mensajeria.Queries.Medico;

namespace Hospital.Handlers.QueriesHandlers
{
    

    public class MedicoHandler : IRequestHandler<ListarMedicosRequest, IEnumerable<ListarMedicosResponse>>,
                                 IRequestHandler<ObtenerMedicoRequest,ObtenerMedicoResponse>
    {

        private readonly IMapper _mapper;
        private readonly AplicationDbContext _context;
        public MedicoHandler(IMapper mapper, AplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<IEnumerable<ListarMedicosResponse>> Handle(ListarMedicosRequest request, CancellationToken cancellationToken)
        {
                 var medicos= _context.Medico.ToList();
            var medicosResponse= new List<ListarMedicosResponse>();

            foreach (var item in medicos)
            {
                var xx=_mapper.Map<ListarMedicosResponse>(item);
                medicosResponse.Add(xx);

            }
            return medicosResponse.AsEnumerable();

           
        }

        public async Task<ObtenerMedicoResponse> Handle(ObtenerMedicoRequest request, CancellationToken cancellationToken)
        {
            var medico= _context.Medico.Where(x=>x.Id==request.Id).FirstOrDefault();
            return  _mapper.Map<ObtenerMedicoResponse>(medico);
        }
    }
}
