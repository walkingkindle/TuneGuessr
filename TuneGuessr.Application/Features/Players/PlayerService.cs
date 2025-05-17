using AutoMapper;
using TuneGuessr.Application.Contracts.Features.Players;
using TuneGuessr.Application.Contracts.Persistence;
using TuneGuessr.Application.ViewModels;
using TuneGuessr.Domain.Entities;

namespace TuneGuessr.Application.Features.Players
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
        public async Task AddPlayer(PlayerVm player)
        {
            await _playerRepository.AddAsync(_mapper.Map<Player>(player));
        }
    }
}
