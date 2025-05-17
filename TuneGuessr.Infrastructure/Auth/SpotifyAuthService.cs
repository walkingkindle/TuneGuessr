using Microsoft.Extensions.Options;
using TuneGuessr.Application.Contracts.Auth;
using TuneGuessr.Infrastructure.Models.Auth;

namespace TuneGuessr.Infrastructure.Auth
{
    public class SpotifyAuthService : ISpotifyAuthService
    {
        private readonly IOptions<SpotifyCredentials> _spotifyCredentials;
        private readonly HttpClient _httpClient;

        public SpotifyAuthService(IOptions<SpotifyCredentials> spotifyCredentials, HttpClient httpClient)
        {
            _spotifyCredentials = spotifyCredentials;
        }
        public async Task Authenticate()
        {
            var formData = new Dictionary<string, string>
            {
                { "grant_type", "client_credentials" },
                { "client_id", _spotifyCredentials.Value.ClientId },
                { "client_secret", _spotifyCredentials.Value.ClientSecret }
            };

            var request = new HttpRequestMessage(HttpMethod.Post, _spotifyCredentials.Value.Url)
            {
                Content = new FormUrlEncodedContent(formData)
            };

            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();
        }


    }
}
