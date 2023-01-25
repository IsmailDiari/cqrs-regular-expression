using AutoMapper;
using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate;
using Engie.Recrutment.RegExExercice.Api.Domain.Interfaces;
using MediatR;

namespace Engie.Recrutment.RegExExercice.Api.Application.Commands.Match;

public sealed class MatchCommandHandler : IRequestHandler<MatchCommand, MatchCommandResponse>
{
    private readonly IMatchRepository _repository;
    private readonly IMapper _mapper;

    public MatchCommandHandler(IMatchRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<MatchCommandResponse> Handle(MatchCommand request, CancellationToken cancellationToken)
    {
        var matchStatement = MatchStatement.Create(request.Pattern, request.Text);

        matchStatement.Match();

        await _repository.SaveAsync(matchStatement);

        return _mapper.Map<MatchCommandResponse>(matchStatement);
    }
}
