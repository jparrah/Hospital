using AutoMapper;
using Hospital.Entidades;
using static Hospital.Mensajeria.Command.Consulta;
using static Hospital.Mensajeria.Command.Medico;
using static Hospital.Mensajeria.Command.Paciente;
using static Hospital.Mensajeria.Command.SeguimientoPacientes;

namespace Hospital.Handlers.CommandHandlers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            
            CreateMap<RegistrarMedicoRequest, Medico>();
            CreateMap<ModificarMedicoRequest, Medico>();
            CreateMap<RegistarConsultaRequest, Consulta>();
            CreateMap<RegistarSeguimientoPacienteRequest, Seguimientos>();
            CreateMap<RegistarPacienteRequest, Paciente>();
        }
    }
}
