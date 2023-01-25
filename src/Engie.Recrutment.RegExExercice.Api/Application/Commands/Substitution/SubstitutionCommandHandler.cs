using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.SubstitutionAggregate;
using Engie.Recrutment.RegExExercice.Api.Domain.Interfaces;
using MediatR;

namespace Engie.Recrutment.RegExExercice.Api.Application.Commands.Substitution;

public sealed class SubstitutionCommandHandler : IRequestHandler<SubstitutionCommand, SubstitutionCommandResponse>
{
    private readonly ISubstitutionRepository _repository;

    public SubstitutionCommandHandler(ISubstitutionRepository repository) => _repository = repository;

    public async Task<SubstitutionCommandResponse> Handle(SubstitutionCommand request, CancellationToken cancellationToken)
    {
        var substitutionStatement = SubstitutionStatement.Create(request.Pattern, request.Text, request.Replace);

        substitutionStatement.Substitute();

        await _repository.SaveAsync(substitutionStatement);

        return new SubstitutionCommandResponse(substitutionStatement.IsSuccess ?? false, substitutionStatement.SubstitutedText);
    }
}