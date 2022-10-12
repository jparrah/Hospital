using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Hospital.Mensajeria.Queries.Medico;

namespace Hospital.Controllers.Queries
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MedicoController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet(Name = "ListarMedicos")]
        [ProducesResponseType(typeof(IEnumerable<ListarMedicosResponse>), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ListarMedicos([FromQuery] ListarMedicosRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }


        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(ObtenerMedicoResponse), (int)System.Net.HttpStatusCode.OK)]
    public async Task<IActionResult> ObtenerMedico([FromQuery] ObtenerMedicoRequest request)
    {
        var respuesta = await _mediator.Send(request);
        return Ok(respuesta);
    }


}
}
