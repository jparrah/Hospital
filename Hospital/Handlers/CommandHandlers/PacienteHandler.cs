using AutoMapper;
using Hospital.Entidades;
using MediatR;
using static Hospital.Mensajeria.Command.Paciente;

namespace Hospital.Handlers.CommandHandlers
{
    public class PacienteHandler : IRequestHandler<RegistarPacienteRequest, bool>,
                                 IRequestHandler<ModificarPacienteRequest, bool>
    {
        private readonly IMapper _mapper;
        private readonly AplicationDbContext _context;

        public PacienteHandler(IMapper mapper, AplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async  Task<bool> Handle(RegistarPacienteRequest request, CancellationToken cancellationToken)
        {
            bool registro = false;
            var paciente = _mapper.Map<Paciente>(request);
            await _context.AddAsync(paciente);
            await _context.SaveChangesAsync();
            registro = true;
            return registro;
        }

        public Task<bool> Handle(ModificarPacienteRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
