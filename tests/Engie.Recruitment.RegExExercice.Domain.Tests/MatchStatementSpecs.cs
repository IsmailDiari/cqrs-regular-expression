using System.Collections.Generic;
using System;
using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate;
using Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Exceptions;
using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate.ValueObjects;

namespace Engie.Recruitment.RegExExercice.Domain.Tests;

public sealed class MatchStatementSpecs
{
    [Theory]
    [InlineData(null, null)]
    [InlineData(null, "lorem")]
    [InlineData("lorem", null)]
    public void Cannot_create_match_instance_with_null_inputs(string pattern, string text)
    {
        Action action = () => MatchStatement.Create(pattern, text);

        action.Should().Throw<BusinessRuleValidationException>();
    }
    [Theory]
    [InlineData("", "")]
    [InlineData("", "lorem")]
    [InlineData("lorem", "")]
    public void Cannot_create_match_instance_with_empty_inputs(string pattern, string text)
    {
        Action action = () => MatchStatement.Create(pattern, text);

        action.Should().Throw<BusinessRuleValidationException>();
    }
    [Fact]
    public void Valid_statment_performs_successfull_match()
    {
        MatchStatement matchStatement = MatchStatement.Create("\\d\\d\\d\\d", "be it 1111 1111 1111 1111 or 8493 2349 5173 8495.");

        matchStatement.Match();

        matchStatement.IsSuccess.Should().BeTrue();
        matchStatement.MatchInformation.Should().NotBe(MatchInformation.Null);
        matchStatement.MatchInformation.Matches.Count.Should().Be(8);
    }
    [Fact]
    public void Invalid_statement_does_nothing()
    {
        MatchStatement matchStatement = MatchStatement.Create("(lorem)", "be it 1111 1111 1111 1111 or 8493 2349 5173 8495.");

        matchStatement.Match();

        matchStatement.IsSuccess.Should().BeFalse();
        matchStatement.MatchInformation.Should().Be(MatchInformation.Null);
    }
}