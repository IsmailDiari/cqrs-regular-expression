namespace Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Exceptions;

#pragma warning disable RCS1194 // Implement exception constructors
public sealed class BusinessRuleValidationException : Exception
{
    public string Details { get; }
    public BusinessRuleValidationException(string message, string details) : base(message)
    {
        Details = details;
    }
}
#pragma warning disable RCS1194