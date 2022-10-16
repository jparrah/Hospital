using MediatR;

namespace Hospital.Mensajeria.Queries
{
    public class SeguimientoPacientes
    {
        public record ListarSeguimientoPacientesRequest:IRequest<IEnumerable<ListarSeguimientoPacientesResponse>>;

        public class ListarSeguimientoPacientesResponse
        {
            public string Id { get; set; }
            public string ConsultaId { get; set; }
            public string PacienteId { get; set; }
            public string Tratamiento { get; set; }
            public string Fecha { get; set; }
            public bool PrimeraVez { get; set; }
            
        }
        public record ObtenerSeguimientoPacienteRequest(string Id):IRequest<ObtenerSeguimientoPacienteResponse>;

        public class ObtenerSeguimientoPacienteResponse
        {
            public string Id { get; set; }
            public string ConsultaId { get; set; }
            public string PacienteId { get; set; }
            public string Tratamiento { get; set; }
            public string Fecha { get; set; }
            public bool PrimeraVez { get; set; }
                   
        }



    }
}
