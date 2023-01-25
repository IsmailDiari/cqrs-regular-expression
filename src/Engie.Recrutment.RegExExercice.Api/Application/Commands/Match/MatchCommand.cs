using MediatR;

namespace Engie.Recrutment.RegExExercice.Api.Application.Commands.Match;

public sealed record MatchCommand(string Pattern, string Text) : IRequest<MatchCommandResponse>;
