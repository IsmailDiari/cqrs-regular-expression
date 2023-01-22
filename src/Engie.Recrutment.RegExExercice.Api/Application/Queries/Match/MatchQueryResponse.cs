namespace Engie.Recrutment.RegExExercice.Api.Application.Queries.Match;

//optional args for automapper
public sealed record MatchQueryResponse(bool IsSuccess = default, MatchInformationResponse MatchInformation = default!);
public sealed record MatchInformationResponse(IList<MatchResponse> Matches = default!);
public sealed record MatchResponse(string MatchedText = default!, int Index = default);