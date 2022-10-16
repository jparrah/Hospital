using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Hospital.Mensajeria.Queries.Medico;

namespace Hospital.Controllers.Queries
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : Controller
    {
        private readonly IMediator _mediator;

        public MedicoController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpPost("ListarMedicos")]
        [ProducesResponseType(typeof(IEnumerable<ListarMedicosResponse>), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ListarMedicos([FromBody] ListarMedicosRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }


        [HttpPost("ObtenerMedico")]
        [ProducesResponseType(typeof(ObtenerMedicoResponse), (int)System.Net.HttpStatusCode.OK)]
         public async Task<IActionResult> ObtenerMedico([FromBody] ObtenerMedicoRequest request)
        {
            var respuesta = await _mediator.Send(request);
             return Ok(respuesta);
        }


}
}
