using Newtonsoft.Json;

namespace TuneGuessr.Infrastructure.Models.Auth
{
    public class SpotifyAuthPayload
    {
        [JsonProperty("grant_type")]
        public string GrantType { get; init; } = "client_credentials";

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("clientSecret")]
        public string ClientSecret { get; set; }


        public SpotifyAuthPayload(string clientId, string clientSecret)
        {
            ClientId = clientId;

            ClientSecret = clientSecret;
        }
    }
}
