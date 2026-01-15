namespace Basics.Tasks;

public class NegativeNumberException : Exception
{
    public NegativeNumberException() : base("Число не может быть отрицательным.")
    {
    }

    public NegativeNumberException(string message) : base(message)
    {
    }

    public NegativeNumberException(string message, Exception innerException) : base(message, innerException)
    {
    }
}