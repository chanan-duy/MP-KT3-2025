namespace MP_KT3_2025;

[Serializable]
public class RegistrationException : Exception
{
    public RegistrationException(string? message) : base(message)
    {
    }

    public RegistrationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
