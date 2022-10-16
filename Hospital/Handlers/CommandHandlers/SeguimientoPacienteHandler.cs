using AutoMapper;
using Hospital.Entidades;
using MediatR;
using static Hospital.Mensajeria.Command.SeguimientoPacientes;

namespace Hospital.Handlers.CommandHandlers
{
    public class SeguimientoPacienteHandler : IRequestHandler<RegistarSeguimientoPacienteRequest, bool>,
                                            IRequestHandler<ModificarSeguimientoPacienteRequest, bool>,
                                            IRequestHandler<EliminarSeguimientoPacienteRequest, bool>
    {
        private readonly AplicationDbContext _context;
        private readonly IMapper _mapper;
        public SeguimientoPacienteHandler(AplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<bool> Handle(RegistarSeguimientoPacienteRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            var seguimiento = _mapper.Map<Seguimientos>(request);
             _context.Seguimientos.Add(seguimiento);
            await _context.SaveChangesAsync();
            result = true;
            return result;
        }

        public async Task<bool> Handle(ModificarSeguimientoPacienteRequest request, CancellationToken cancellationToken)
        {
            var result = false;

            var seguimiento = _mapper.Map<Seguimientos>(request);
            _context.Seguimientos.Update(seguimiento);
            await _context.SaveChangesAsync();
            result = true;

            return result;
        }

        public async Task<bool> Handle(EliminarSeguimientoPacienteRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            var seguimiento = _context.Seguimientos.Where(x => x.Id == request.Id).FirstOrDefault();
            _context.Seguimientos.Remove(seguimiento);
            await _context.SaveChangesAsync();
            result = true;
            return result;
        }
    }
}
