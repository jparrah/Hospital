using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Hospital.Mensajeria.Queries.Paciente;

namespace Hospital.Controllers.Queries
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : Controller
    {
        private readonly IMediator _mediator;

        public PacienteController(IMediator mediator)
        {
            _mediator=mediator;
        }

        [HttpPost("ListarPacientes")]
        [ProducesResponseType(typeof(IEnumerable<ListarPacientesResponse>), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ListarPacientes([FromBody] ListarPacientesRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }


        [HttpPost("ObtenerPaciente")]
        [ProducesResponseType(typeof(ObtenerPacienteResponse), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ObtenerPaciente([FromBody] ObtenerPacienteRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }
    }
}
