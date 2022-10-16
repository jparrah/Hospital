using AutoMapper;
using Hospital.Entidades;
using MediatR;
using static Hospital.Mensajeria.Command.Paciente;

namespace Hospital.Handlers.CommandHandlers
{
    public class PacienteHandler : IRequestHandler<RegistarPacienteRequest, bool>,
                                 IRequestHandler<ModificarPacienteRequest, bool>,
                                IRequestHandler<EliminarPacienteRequest, bool>
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

        public async Task<bool> Handle(ModificarPacienteRequest request, CancellationToken cancellationToken)
        {
            var result = false;

            var paciente = _mapper.Map<Paciente>(request);
            _context.Paciente.Update(paciente);
            await _context.SaveChangesAsync();
            result = true;

            return result;
        }

        public async Task<bool> Handle(EliminarPacienteRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            var paciente = _context.Paciente.Where(x => x.Id == request.Id).FirstOrDefault();
            _context.Paciente.Remove(paciente);
            await _context.SaveChangesAsync();
            result = true;
            return result;
        }
    }
}
