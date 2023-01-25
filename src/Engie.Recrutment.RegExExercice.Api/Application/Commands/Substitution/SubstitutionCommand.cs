using MediatR;

namespace Engie.Recrutment.RegExExercice.Api.Application.Commands.Substitution;

public sealed record SubstitutionCommand(string Pattern, string Text, string Replace) : IRequest<SubstitutionCommandResponse>;