using MediatR;

namespace Hospital.Mensajeria.Command
{
    public class Medico
    {
        public record RegistrarMedicoRequest(
                            string Id,
                            string ConsultaId,
                            string Nombre,
                            string PrimerApellido,
                            string SegundoApellido,
                            string Especialidad,
                            string Email,
                            string Telefono):IRequest<bool>;

        public record ModificarMedicoRequest(
                            string Id,
                            string ConsultaId,
                            string Nombre,
                            string PrimerApellido,
                            string SegundoApellido,
                            string Especialidad,
                            string Email,
                            string Telefono) :IRequest<bool>;
        public record EliminarMedicoRequest(string Id) : IRequest<bool>;



    }

    }

