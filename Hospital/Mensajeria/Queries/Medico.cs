using MediatR;

namespace Hospital.Mensajeria.Queries
{
    public class Medico
    {
        public record ListarMedicosRequest:IRequest<IEnumerable<ListarMedicosResponse>>;

       public class ListarMedicosResponse
        {
            public string Id { get; set; }
            public string IdConsulta { get; set; }
            public string NombreUnido { get; set; }

            public string Especialidad { get; set; }

            public string Email { get; set; }

            public string Telefono { get; set; }
        }

        public record ObtenerMedicoRequest(string Id): IRequest<ObtenerMedicoResponse>;

        public class ObtenerMedicoResponse
        {
            public string Id { get; set; }
            public string IdConsulta { get; set; }
            public string NombreUnido { get; set; }

            public string Especialidad { get; set; }

            public string Email { get; set; }

            public string Telefono { get; set; }
        }
    }
}
