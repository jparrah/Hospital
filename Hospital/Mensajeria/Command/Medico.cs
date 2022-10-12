using MediatR;

namespace Hospital.Mensajeria.Command
{
    public class Medico
    {
        public record RegistrarMedicoRequest(
                            string Id,
                            string IdConsulta,
                            string Nombre,
                            string PrimerApellido,
                            string SegundoApellido,
                            string Especialidad,
                            string Email,
                            string Telefono):IRequest<bool>;

        public record ModificarMedicoRequest(
                            string Id,
                            string IdConsulta,
                            string Nombre,
                            string Apellidos,
                            string Especialidad,
                            string Email,
                            string Telefono) :IRequest<bool>;

        

        }

    }

