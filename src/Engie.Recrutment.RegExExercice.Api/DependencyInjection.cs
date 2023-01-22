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
        //#FixMe: AddControllers is useless here, it is added to bypass problem with AddProblemDetails
        services.AddControllers();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddProblemDetails(configure =>
            {
                configure.IncludeExceptionDetails = (ctx, exception) => false;
                configure.Map<InvalidCommandException>(ex => new InvalidCommandProblemDetails(ex));
                configure.Map<BusinessRuleValidationException>(ex => new BusinessRuleValidationExceptionProblemDetails(ex));
            });
        return services;
    }
}