using Hospital.Entidades;
using MediatR;

namespace Hospital.Mensajeria.Queries
{
    public class Paciente
    {
        public record ListarPacientesRequest:IRequest<IEnumerable<ListarPacientesResponse>>;

        public class ListarPacientesResponse
        {
            public string Id { get; set; }  
            public string NombreUnido { get; set; }
            public int Edad { get; set; }
            public string Sexo { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
           
        }

        public record ObtenerPacienteRequest(string Id):IRequest<ObtenerPacienteResponse>;


        public class ObtenerPacienteResponse
        {
            public string Id { get; set; }
            public string NombreUnido { get; set; }
            public int Edad { get; set; }
            public string Sexo { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            
        }
    }
}
