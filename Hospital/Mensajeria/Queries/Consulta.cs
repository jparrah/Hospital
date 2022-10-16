using Hospital.Entidades;
using MediatR;
using static Hospital.Mensajeria.Queries.Medico;
using static Hospital.Mensajeria.Queries.SeguimientoPacientes;

namespace Hospital.Mensajeria.Queries
{
    public class Consulta
    {
        public record ListarConsultaRequest:IRequest<IEnumerable<ListarConsultaResponse>>;

        public class ListarConsultaResponse
        {
            public string Id { get; set; }

            public string Nombre { get; set; }
        }

        public record ObtenerConsultaRequest(string Id):IRequest<ObtenerConsultaResponse>;

        public class ObtenerConsultaResponse
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
        }
    }
}
