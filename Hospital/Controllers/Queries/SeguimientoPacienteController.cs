using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Hospital.Mensajeria.Queries.SeguimientoPacientes;

namespace Hospital.Controllers.Queries
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


        [HttpPost("ListarSeguimientos")]
        [ProducesResponseType(typeof(IEnumerable<ListarSeguimientoPacientesResponse>), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ListarSeguimientos([FromBody] ListarSeguimientoPacientesRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }


        [HttpPost("ObtenerSeguimiento")]
        [ProducesResponseType(typeof(ObtenerSeguimientoPacienteResponse), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ObtenerSeguimiento([FromBody] ObtenerSeguimientoPacienteRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }
    }
}
