namespace Basics.Exceptions;

public class NegativeNumberException: ArgumentException
{
    public NegativeNumberException(string? paramName) 
        : base("Число не должно быть отрицательным.", paramName) { }
    
    public NegativeNumberException(int invalidValue, string paramName)
        : base($"Значение '{invalidValue}' параметра '{paramName}' не должно быть отрицательным.", paramName)
    { }

    public NegativeNumberException(string? message, string? paramName) 
        : base(message, paramName) { }

    public NegativeNumberException(string? message, string? paramName, Exception? innerException) 
        : base(message, paramName, innerException) { }
}