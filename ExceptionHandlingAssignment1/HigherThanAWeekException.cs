// See https://aka.ms/new-console-template for more information

using System.Runtime.Serialization;

[Serializable]
internal class HigherThanAWeekException : Exception
{
    public HigherThanAWeekException()
    {
    }

    public HigherThanAWeekException(string? message) : base(message)
    {
    }

    public HigherThanAWeekException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected HigherThanAWeekException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}