using MediatR;

namespace Hospital.Mensajeria.Command
{
    public class Paciente
    {
        public record RegistarPacienteRequest(
                                    string Id,
                                    string Nombre,
                                    string PrimerApellido,
                                    string SegundoApellido,
                                    int Edad ,
                                    string Sexo,
                                    string Email,
                                    string Telefono,
                                    string Direccion):IRequest<bool>;

        public record ModificarPacienteRequest(
                                    string Id,
                                    string Nombre,
                                    string PrimerApellido,
                                    string SegundoApellido,
                                    int Edad,
                                    string Sexo,
                                    string Email,
                                    string Telefono,
                                    string Direccion) :IRequest<bool>;
        public record EliminarPacienteRequest(string Id) : IRequest<bool>;
    }
}
