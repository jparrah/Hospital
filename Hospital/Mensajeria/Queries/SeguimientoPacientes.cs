using MediatR;

namespace Hospital.Mensajeria.Queries
{
    public class SeguimientoPacientes
    {
        public record ListarSeguimientoPacientesRequest:IRequest<IEnumerable<ListarSeguimientoPacientesResponse>>;

        public class ListarSeguimientoPacientesResponse
        {
            public string Id { get; set; }
            public string IdConsulta { get; set; }
            public string IdPaciente { get; set; }
            public string Tratamiento { get; set; }
            public string Fecha { get; set; }
            public bool PrimeraVez { get; set; }
            public string FechaProxima { get; set; }
        }
        public record ObtenerSeguimientoPacienteRequest(string Id):IRequest<ObtenerSeguimientoPacienteResponse>;

        public class ObtenerSeguimientoPacienteResponse
        {
            public string Id { get; set; }
            public string IdConsulta { get; set; }
            public string IdPaciente { get; set; }
            public string Tratamiento { get; set; }
            public string Fecha { get; set; }
            public bool PrimeraVez { get; set; }
            public string FechaProxima { get; set; }        
        }



    }
}
