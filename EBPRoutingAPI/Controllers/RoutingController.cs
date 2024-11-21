using Microsoft.AspNetCore.Mvc;

using EBPRoutingAPI.Domain.Interfaces;
using EBPRoutingAPI.DTO;

namespace EBPRoutingAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutingAPIController(IRoutingValidator routingValidator, IRoutingRepository routingRepository) : ControllerBase
    {
        private readonly IRoutingValidator _routingValidator = routingValidator;
        private readonly IRoutingRepository _routingRepository = routingRepository;

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] IRoutingDTO routing)
        {
            try
            {
                //Mauvais paramétrage
                string badReqMsg = "Le paramètre 'client' est manquant ou mal formé.";
                if (routing == null || !_routingValidator.Validate(routing))
                {
                    return BadRequest(new { error = badReqMsg });
                }

                //Evaluer la regles
                var routingQueue = await _routingRepository.EvaluateRule(routing.Client, routing.Licence);

                return routingQueue != null
                       ? Ok(new QueueDTO { QueueCode = routingQueue.Code })
                       : BadRequest(new { error = badReqMsg });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                new
                {
                    error = "Une erreur interne s'est produite. Veuillez contacter votre service Informatique"
                });
            }
        }
    }
}
