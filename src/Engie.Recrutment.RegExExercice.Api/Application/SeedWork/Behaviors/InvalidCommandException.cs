namespace Engie.Recrutment.RegExExercice.Api.Application.SeedWork.Behaviors;

#pragma warning disable RCS1194 // Implement exception constructors
public sealed class InvalidCommandException : Exception
{
    public string Details { get; }
    public InvalidCommandException(string message, string details = null) : base(message)
    {
        this.Details = details;
    }
}
#pragma warning restore RCS1194 // Implement exception constructors