// See https://aka.ms/new-console-template for more information

using System.Runtime.Serialization;

[Serializable]
internal class WageIsZeroExceptionOrNegative : Exception
{
    public WageIsZeroExceptionOrNegative()
    {
    }

    public WageIsZeroExceptionOrNegative(string? message) : base(message)
    {
    }

    public WageIsZeroExceptionOrNegative(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected WageIsZeroExceptionOrNegative(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}