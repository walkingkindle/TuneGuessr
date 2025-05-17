using MediatR;
using Microsoft.AspNetCore.Mvc;
using TuneGuessr.Application.Contracts.Features.Players;
using TuneGuessr.Application.ViewModels;

namespace TuneGuessr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IMediator mediator, IPlayerService playerService)
        {
            _playerService = playerService;
        }


        [HttpPost("/player")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> CreatePlayer(PlayerVm player)
        {
            await _playerService.AddPlayer(player);

            return Ok();
        }


    }
}
