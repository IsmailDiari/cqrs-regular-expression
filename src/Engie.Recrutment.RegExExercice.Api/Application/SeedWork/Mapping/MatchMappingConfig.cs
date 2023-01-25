using AutoMapper;
using Engie.Recrutment.RegExExercice.Api.Application.Commands.Match;
using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate;
using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate.ValueObjects;

namespace Engie.Recrutment.RegExExercice.Api.Application.SeedWork.Mapping;

public sealed class MatchMappingConfig : Profile
{
    public MatchMappingConfig()
    {
        CreateMap<MatchStatement, MatchCommandResponse>();
        CreateMap<MatchInformation, MatchInformationResponse>();
        CreateMap<Match, MatchResponse>();
    }
}