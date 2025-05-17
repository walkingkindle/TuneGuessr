using Microsoft.AspNetCore.Mvc;
using TuneGuessr.Application.Contracts.Auth;

namespace TuneGuessr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyAuthController : ControllerBase
    {

        private readonly ISpotifyAuthService _spotifyAuthService;

        public SpotifyAuthController(ISpotifyAuthService spotifyAuthService)
        {
            _spotifyAuthService = spotifyAuthService;
        }


        [HttpGet("authenticate")]
        public RedirectResult AuthenticateSpotify()
        {
            return Redirect(_spotifyAuthService.GetAuthorizationURL());
        }
    }
}
