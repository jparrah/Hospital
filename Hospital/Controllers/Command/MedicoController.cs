using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Hospital.Mensajeria.Command.Medico;

namespace Hospital.Controllers.Command
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MedicoController(IMediator mediator)
        {
            _mediator=mediator;
        }




        [HttpPost(Name = "RegistrarMedico")]
        [ProducesResponseType(typeof(bool), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> RegistrarMedico([FromBody] RegistrarMedicoRequest request)
        {
            var respuesta= await _mediator.Send(request);
            return Ok(respuesta);
        }



        [HttpPut(Name = "ModificarMedico")]
        [ProducesResponseType(typeof(bool), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> ModificarMedico([FromBody] ModificarMedicoRequest request)
        {
            var respuesta = await _mediator.Send(request);
            return Ok(respuesta);
        }
    }
}
