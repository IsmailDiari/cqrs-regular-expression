using Engie.Recrutment.RegExExercice.Api;
using Engie.Recrutment.RegExExercice.Api.Application;
using Engie.Recrutment.RegExExercice.Api.Application.Queries.MatchQuery;
using Engie.Recrutment.RegExExercice.Api.Application.Queries.Substitution;
using Engie.Recrutment.RegExExercice.Api.Contracts.Match;
using Engie.Recrutment.RegExExercice.Api.Contracts.Substitution;
using Engie.Recrutment.RegExExercice.Api.Infrastructure;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddPresentation()
        .AddApplication()
        .AddInfrastructure();
}

var app = builder.Build();
{
    //app.UseProblemDetails();
    app.MapPost("/api/v1/regular-expressions/match", async (MatchRequest request, ISender mediator)
                                                        => await mediator.Send(new MatchQuery(request.Pattern, request.Text)));

    app.MapPost("/api/v1/regular-expressions/substitution", async (SubstitutionRequest request, ISender mediator)
                                                        => await mediator.Send(new SubstitutionQuery(request.Pattern, request.Text, request.Replace)));

    app.Run();
}
