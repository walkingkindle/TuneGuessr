using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.Text;
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
        public string GetAuthorizationURL()
        {
            string codeVerifier = GenerateCodeVerifier();
            string codeChallenge = GenerateCodeChallenge(codeVerifier);
            //var formData = new Dictionary<string, string>
            //{
            //    {"response_type", "code" },
            //    {"client_id", _spotifyCredentials.Value.ClientId },
            //    {"redirect_uri","https://localhost:7223/auth/callback" },
            //    {"scope","openid profile email" },
            //    {"code_challenge",codeChallenge},
            //    {"code_challenge_method","S256" }
            //};
            string authorizationUrl = QueryHelpers.AddQueryString("https://accounts.spotify.com/authorize", new Dictionary<string, string>
            {
                { "client_id", _spotifyCredentials.Value.ClientId },
                { "response_type", "code" },
                { "redirect_uri", "https://localhost:7223/auth/callback" },
                { "scope", "playlist-read-private user-read-email user-read-private" },
                { "code_challenge_method", "S256" },
                { "code_challenge", codeChallenge }
            });

            return authorizationUrl;


        }

        private string GenerateCodeVerifier()
        {
            var bytes = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            return Base64UrlEncode(bytes);
        }

        private string GenerateCodeChallenge(string codeVerifier)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.ASCII.GetBytes(codeVerifier));
            return Base64UrlEncode(bytes);
        }

        private string Base64UrlEncode(byte[] input)
        {
            return Convert.ToBase64String(input)
                .Replace("+", "-")
                .Replace("/", "_")
                .Replace("=", "");
        }
    }
}
