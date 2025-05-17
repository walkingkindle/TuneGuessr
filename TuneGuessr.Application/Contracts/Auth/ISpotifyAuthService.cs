namespace TuneGuessr.Application.Contracts.Auth
{
    public interface ISpotifyAuthService
    {
        public Task Authenticate();
    }
}
