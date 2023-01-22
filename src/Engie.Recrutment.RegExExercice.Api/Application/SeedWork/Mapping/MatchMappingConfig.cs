using AutoMapper;
using Engie.Recrutment.RegExExercice.Api.Application.Queries.Match;
using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate;
using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate.ValueObjects;

namespace Engie.Recrutment.RegExExercice.Api.Application.SeedWork.Mapping;

public sealed class MatchMappingConfig : Profile
{
    public MatchMappingConfig()
    {
        CreateMap<MatchStatement, MatchQueryResponse>();
        CreateMap<MatchInformation, MatchInformationResponse>();
        CreateMap<Match, MatchResponse>();
    }
}