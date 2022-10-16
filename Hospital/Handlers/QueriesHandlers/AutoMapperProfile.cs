using AutoMapper;
using Hospital.Entidades;
using static Hospital.Mensajeria.Queries.Consulta;
using static Hospital.Mensajeria.Queries.Medico;
using static Hospital.Mensajeria.Queries.Paciente;
using static Hospital.Mensajeria.Queries.SeguimientoPacientes;

namespace Hospital.Handlers.QueriesHandlers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Medico, ObtenerMedicoResponse>()
               .ForMember(x=>x.NombreUnido, opt=>opt.MapFrom(x=>x.Nombre +" "+ x.PrimerApellido+" "+x.SegundoApellido));

            CreateMap<Medico, ListarMedicosResponse>()
                .ForMember(x=>x.NombreUnido,opt=>opt.MapFrom(x=>x.Nombre + " " + x.PrimerApellido + " " + x.SegundoApellido));

            CreateMap<Consulta, ListarConsultaResponse>();
            CreateMap<Consulta, ObtenerConsultaResponse>();
            CreateMap<Paciente, ListarPacientesResponse>()
                .ForMember(x => x.NombreUnido, opt => opt.MapFrom(x => x.Nombre + " " + x.PrimerApellido + " " + x.SegundoApellido));

            CreateMap<Paciente, ObtenerPacienteResponse>()
                .ForMember(x => x.NombreUnido, opt => opt.MapFrom(x => x.Nombre + " " + x.PrimerApellido + " " + x.SegundoApellido));

            CreateMap<Seguimientos, ListarSeguimientoPacientesResponse>();
            CreateMap<Seguimientos, ObtenerSeguimientoPacienteResponse>();
        }
    }
}
