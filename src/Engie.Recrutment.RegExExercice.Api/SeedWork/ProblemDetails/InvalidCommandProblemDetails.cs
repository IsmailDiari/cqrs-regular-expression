using Engie.Recrutment.RegExExercice.Api.Application.SeedWork.Behaviors;

namespace Engie.Recrutment.RegExExercice.Api.SeedWork.ProblemDetails;

public sealed class InvalidCommandProblemDetails : Microsoft.AspNetCore.Mvc.ProblemDetails
{
    public InvalidCommandProblemDetails(InvalidCommandException exception)
    {
        Title = exception.Message;
        Status = StatusCodes.Status400BadRequest;
        Detail = exception.Details;
    }
}