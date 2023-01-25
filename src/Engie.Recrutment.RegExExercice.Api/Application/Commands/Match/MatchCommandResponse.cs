namespace Engie.Recrutment.RegExExercice.Api.Application.Commands.Match;

//optional args for automapper
public sealed record MatchCommandResponse(bool IsSuccess = default, MatchInformationResponse MatchInformation = default!);
public sealed record MatchInformationResponse(IList<MatchResponse> Matches = default!);
public sealed record MatchResponse(string MatchedText = default!, int Index = default);