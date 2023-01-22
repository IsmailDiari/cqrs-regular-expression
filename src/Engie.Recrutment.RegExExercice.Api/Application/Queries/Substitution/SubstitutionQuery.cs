using MediatR;

namespace Engie.Recrutment.RegExExercice.Api.Application.Queries.Substitution;

public sealed record SubstitutionQuery(string Pattern, string Text, string Replace) : IRequest<SubstitutionQueryResponse>;