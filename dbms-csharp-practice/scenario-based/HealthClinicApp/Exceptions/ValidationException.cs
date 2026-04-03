namespace HealthClinicApp.Exceptions;

public class ValidationException : ClinicException
{
    public ValidationException(string message) : base(message)
    {
    }
}

