using System.Reflection;

using Hellang.Middleware.ProblemDetails;

using Engie.Recrutment.RegExExercice.Api.Application.SeedWork.Behaviors;
using Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Exceptions;
using Engie.Recrutment.RegExExercice.Api.SeedWork.ProblemDetails;

namespace Engie.Recrutment.RegExExercice.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        // services.AddProblemDetails(x =>
        //     {
        //         x.Map<InvalidCommandException>(ex => new InvalidCommandProblemDetails(ex));
        //         x.Map<BusinessRuleValidationException>(ex => new BusinessRuleValidationExceptionProblemDetails(ex));
        //     });
        return services;
    }
}