using Engie.Recrutment.RegExExercice.Api;
using Engie.Recrutment.RegExExercice.Api.Application;
using Engie.Recrutment.RegExExercice.Api.Application.Commands.Match;
using Engie.Recrutment.RegExExercice.Api.Application.Commands.Substitution;
using Engie.Recrutment.RegExExercice.Api.Contracts.Match;
using Engie.Recrutment.RegExExercice.Api.Contracts.Substitution;
using Engie.Recrutment.RegExExercice.Api.Infrastructure;
using Hellang.Middleware.ProblemDetails;
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
    app.UseProblemDetails();
    app.MapPost("/api/v1/regular-expressions/matches", async (MatchRequest request, ISender mediator)
                                                        => await mediator.Send(new MatchCommand(request.Pattern, request.Text)));

    app.MapPost("/api/v1/regular-expressions/substitutions", async (SubstitutionRequest request, ISender mediator)
                                                        => await mediator.Send(new SubstitutionCommand(request.Pattern, request.Text, request.Replace)));

    app.Run();
}
