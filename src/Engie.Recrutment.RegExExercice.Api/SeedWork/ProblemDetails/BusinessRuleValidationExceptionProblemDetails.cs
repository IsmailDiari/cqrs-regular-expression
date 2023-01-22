using Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Exceptions;

namespace Engie.Recrutment.RegExExercice.Api.SeedWork.ProblemDetails;

public sealed class BusinessRuleValidationExceptionProblemDetails : Microsoft.AspNetCore.Mvc.ProblemDetails
{
    public BusinessRuleValidationExceptionProblemDetails(BusinessRuleValidationException exception)
    {
        Title = exception.Message;
        Status = StatusCodes.Status400BadRequest;
        Detail = exception.Details;
    }
}