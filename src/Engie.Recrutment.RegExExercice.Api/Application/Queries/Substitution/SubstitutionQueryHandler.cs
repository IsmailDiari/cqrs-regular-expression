using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.SubstitutionAggregate;
using Engie.Recrutment.RegExExercice.Api.Domain.Interfaces;
using MediatR;

namespace Engie.Recrutment.RegExExercice.Api.Application.Queries.Substitution;

public sealed class SubstitutionQueryHandler : IRequestHandler<SubstitutionQuery, SubstitutionQueryResponse>
{
    private readonly ISubstitutionRepository _repository;

    public SubstitutionQueryHandler(ISubstitutionRepository repository) => _repository = repository;

    public async Task<SubstitutionQueryResponse> Handle(SubstitutionQuery request, CancellationToken cancellationToken)
    {
        var substitutionStatement = SubstitutionStatement.Create(request.Pattern, request.Text, request.Replace);

        substitutionStatement.Substitute();

        await _repository.SaveAsync(substitutionStatement);

        return new SubstitutionQueryResponse(substitutionStatement.IsSuccess ?? false, substitutionStatement.SubstitutedText);
    }
}