using AutoMapper;
using Hospital.Entidades;
using static Hospital.Mensajeria.Queries.Medico;

namespace Hospital.Handlers.QueriesHandlers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Medico, ObtenerMedicoResponse>()
               .ForMember(x=>x.NombreUnido, opt=>opt.MapFrom(x=>x.Nombre + x.PrimerApellido+x.SegundoApellido));

            CreateMap<Medico, ListarMedicosResponse>()
                .ForMember(x=>x.NombreUnido,opt=>opt.MapFrom(x=>x.Nombre + x.PrimerApellido + x.SegundoApellido));
        }
    }
}
