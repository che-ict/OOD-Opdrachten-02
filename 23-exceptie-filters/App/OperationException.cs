namespace App;

public class OperationException : Exception
{
    public int ErrorCode { get; }
    public OperationException(int errorCode) { ErrorCode = errorCode; }
}
