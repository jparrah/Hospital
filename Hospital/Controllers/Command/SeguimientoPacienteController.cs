using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Hospital.Mensajeria.Command.SeguimientoPacientes;

namespace Hospital.Controllers.Command
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguimientoPacienteController : Controller
    {
        private readonly IMediator _mediator;
        public SeguimientoPacienteController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpPost("RegistrarSeguimientoPaciente")]
        [ProducesResponseType(typeof(bool), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> RegistrarSeguimientoPaciente([FromBody] RegistarSeguimientoPacienteRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }


        [HttpPost("ModificarSeguimientoPaciente")]
        [ProducesResponseType(typeof(bool), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ModificarSeguimientoPaciente([FromBody] ModificarSeguimientoPacienteRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }

        [HttpPost("EliminarSeguimientoPaciente")]
        [ProducesResponseType(typeof(bool), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> EliminarSeguimientoPaciente([FromBody] EliminarSeguimientoPacienteRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }
    }
}
