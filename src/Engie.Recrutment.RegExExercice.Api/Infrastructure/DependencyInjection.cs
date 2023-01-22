using Engie.Recrutment.RegExExercice.Api.Domain.Interfaces;
using Engie.Recrutment.RegExExercice.Api.Infrastructure.Repositories;

namespace Engie.Recrutment.RegExExercice.Api.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IMatchRepository, MatchRepository>();
        services.AddScoped<ISubstitutionRepository, SubstitutionRepository>();
        return services;
    }
}