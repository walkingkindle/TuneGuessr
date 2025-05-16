using MediatR;
namespace TuneGuessr.Application.Features.Users
{
    public class CreatePlayerCommand : IRequest<int>
    {
        public string Name { get; set; }

        public int SpotifyId { get; set; }

    }
}
