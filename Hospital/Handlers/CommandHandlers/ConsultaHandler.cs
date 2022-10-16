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
                                 IRequestHandler<ModificarConsultaRequest, bool>,
                                 IRequestHandler<EliminarConsultaRequest, bool>
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
            await _contexto.Consulta.AddAsync(consulta);
            _contexto.SaveChanges();
            
            registro = true;
           
            return registro;
        }

        public async Task<bool> Handle(ModificarConsultaRequest request, CancellationToken cancellationToken)
        {
            var resultado = false;
            var consulta = _contexto.Consulta.Where(x => x.Id == request.Id).FirstOrDefault();
            if(consulta != null)
            {
                consulta.Nombre=request.Nombre;
                _contexto.Consulta.Update(consulta);
                await _contexto.SaveChangesAsync();
            }
            
            resultado = true;

            return resultado; 


        }

        public async  Task<bool> Handle(EliminarConsultaRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            var consulta= _contexto.Consulta.Where(x => x.Id == request.Id).FirstOrDefault();
            _contexto.Consulta.Remove(consulta);
            await _contexto.SaveChangesAsync();
            result = true;
            return result;
        }
    }
}
