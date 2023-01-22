using Engie.Recrutment.RegExExercice.Api.Application.Queries.Match;
using MediatR;

namespace Engie.Recrutment.RegExExercice.Api.Application.Queries.MatchQuery;

public sealed record MatchQuery(string Pattern, string Text) : IRequest<MatchQueryResponse>;
