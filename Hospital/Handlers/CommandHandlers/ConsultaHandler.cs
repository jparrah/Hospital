using AutoMapper;
using Hospital.Entidades;
using Hospital.Mensajeria.Command;
using MediatR;
using static Hospital.Mensajeria.Command.Consulta;
using Consulta = Hospital.Entidades.Consulta;
using static Microsoft.EntityFrameworkCore.DbContext;
using Medico = Hospital.Entidades.Medico;
using System.Linq;

namespace Hospital.Handlers.CommandHandlers
{
    public class ConsultaHandler : IRequestHandler<RegistarConsultaRequest, bool>,
                                 IRequestHandler<ModificarConsultaRequest, bool>
    {
        private readonly IMapper _mapper;
        private readonly AplicationDbContext _contexto;

        public ConsultaHandler(IMapper mapper, AplicationDbContext contexto)
        {
            _mapper = mapper;
            _contexto = contexto;
        }
        public async Task<bool> Handle(RegistarConsultaRequest request, CancellationToken cancellationToken)
        {
            
            var registro = false;
            var consulta = _mapper.Map<Consulta>(request);
            

            foreach (var item in request.Seguimientos)
            {
                var nuevoSeguimiento = _mapper.Map<Seguimientos>(item);
                consulta.Seguimientos.Append(nuevoSeguimiento);
                
            }
            foreach (var item in request.Medicos)
            {
                var nuevoMedico = _mapper.Map<Medico>(item);
                consulta.Medicos.Append(nuevoMedico);
                
            }
            await _contexto.Consulta.AddAsync(consulta);
            _contexto.SaveChanges();
            
            registro = true;
           
            return registro;
        }

        public Task<bool> Handle(ModificarConsultaRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
