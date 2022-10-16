using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Hospital.Mensajeria.Queries.Consulta;

namespace Hospital.Controllers.Queries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : Controller
    {
        private readonly IMediator _mediator;

        public ConsultaController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpPost("ListarConsultas")]
        [ProducesResponseType(typeof(IEnumerable<ListarConsultaResponse>), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ListarConsultas([FromBody] ListarConsultaRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }


        [HttpPost("ObtenerConsulta")]
        [ProducesResponseType(typeof(ObtenerConsultaResponse), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ObtenerConsulta([FromBody] ObtenerConsultaRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }
    }
}
