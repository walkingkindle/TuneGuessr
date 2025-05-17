using TuneGuessr.Application.ViewModels;

namespace TuneGuessr.Application.Contracts.Features.Players
{
    public interface IPlayerService
    {
        Task AddPlayer(PlayerVm player);
    }
}
