// See https://aka.ms/new-console-template for more information

using System.Runtime.Serialization;

[Serializable]
internal class NoNameEnteredException : Exception
{
    public NoNameEnteredException()
    {
    }

    public NoNameEnteredException(string? message) : base(message)
    {
    }

    public NoNameEnteredException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NoNameEnteredException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}