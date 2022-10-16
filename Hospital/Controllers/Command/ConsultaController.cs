using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Hospital.Mensajeria.Command.Consulta;

namespace Hospital.Controllers.Command
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : Controller
    {
        private readonly IMediator _mediator;
        public ConsultaController(IMediator mediator)
        {
            _mediator=mediator;
        }


        [HttpPost("RegistrarConsulta")]
        [ProducesResponseType(typeof(bool), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> RegistrarConsulta([FromBody] RegistarConsultaRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }


        [HttpPost("ModificarConsulta")]
        [ProducesResponseType(typeof(bool), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ModificarConsulta([FromBody] ModificarConsultaRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }

        [HttpPost("EliminarConsulta")]
        [ProducesResponseType(typeof(bool), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> EliminarConsulta([FromBody] EliminarConsultaRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }
    }
}
