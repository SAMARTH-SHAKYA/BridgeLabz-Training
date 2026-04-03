namespace HealthClinicApp.Exceptions;

public class ClinicException : Exception
{
    public ClinicException(string message) : base(message)
    {
    }

    public ClinicException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

