using AutoMapper;
using Hospital.Entidades;
using Hospital.Mensajeria.Command;
using MediatR;
using static Hospital.Mensajeria.Command.Medico;
using Consulta = Hospital.Entidades.Consulta;
using Medico = Hospital.Entidades.Medico;

namespace Hospital.Handlers.CommandHandlers
{
    public class MedicoHandlers : IRequestHandler<RegistrarMedicoRequest, bool>,
                                  IRequestHandler<ModificarMedicoRequest,bool>
    {
        private readonly IMapper _mapper;
        private readonly AplicationDbContext _context;
        public MedicoHandlers(IMapper mapper, AplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<bool> Handle(RegistrarMedicoRequest request, CancellationToken cancellationToken)
        {
            bool result = false;
            var medico=  _mapper.Map<Medico>(request);
            await _context.Medico.AddAsync(medico);
            await _context.SaveChangesAsync();
            result = true;
            return result;
            
            

        }

        public async Task<bool> Handle(ModificarMedicoRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            
            var medico= _mapper.Map<Medico>(request);
            _context.Medico.Update(medico);
            await _context.SaveChangesAsync();
            result = true;

            return result;
        }
    }
}
