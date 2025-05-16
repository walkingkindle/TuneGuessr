using AutoMapper;
using MediatR;
using TuneGuessr.Application.Contracts.Persistence;
using TuneGuessr.Application.ViewModels;
using TuneGuessr.Domain.Entities;

namespace TuneGuessr.Application.Features.Users
{
    public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, int>
    {
        private readonly IAsyncRepository<Player> _playerRepository;

        private readonly IMapper _mapper;

        public CreatePlayerCommandHandler(IAsyncRepository<Player> playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            var player = await _playerRepository.AddAsync(_mapper.Map<Player>(request));

            return player.Id;
        }
    }
}
