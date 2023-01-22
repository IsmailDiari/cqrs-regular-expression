using AutoMapper;
using Engie.Recrutment.RegExExercice.Api.Application.Queries.Match;
using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate;
using Engie.Recrutment.RegExExercice.Api.Domain.Interfaces;
using MediatR;

namespace Engie.Recrutment.RegExExercice.Api.Application.Queries.MatchQuery;

public sealed class MatchQueryHandler : IRequestHandler<MatchQuery, MatchQueryResponse>
{
    private readonly IMatchRepository _repository;
    private readonly IMapper _mapper;

    public MatchQueryHandler(IMatchRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<MatchQueryResponse> Handle(MatchQuery request, CancellationToken cancellationToken)
    {
        var matchStatement = MatchStatement.Create(request.Pattern, request.Text);

        matchStatement.Match();

        await _repository.SaveAsync(matchStatement);

        return _mapper.Map<MatchQueryResponse>(matchStatement);
    }
}
