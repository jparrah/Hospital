using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Hospital.Mensajeria.Command.Paciente;

namespace Hospital.Controllers.Command
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PacienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "RegistrarPaciente")]
        [ProducesResponseType(typeof(bool), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> RegistrarPaciente([FromBody] RegistarPacienteRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }

        [HttpPut(Name = "ModificarPaciente")]
        [ProducesResponseType(typeof(bool), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ModificarPaciente([FromBody] ModificarPacienteRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }
    }
}
