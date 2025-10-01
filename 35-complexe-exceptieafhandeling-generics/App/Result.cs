namespace App;

public class Result<T>
{
    public T Value { get; }
    public Exception Error { get; }
    public bool IsSuccess => Error == null;

    private Result(T value)
    {
        // TODO: Implement constructor for success case
        throw new NotImplementedException();
    }

    private Result(Exception error)
    {
        // TODO: Implement constructor for failure case
        throw new NotImplementedException();
    }

    public static Result<T> Ok(T value)
    {
        // TODO: Implement static factory method for success result
        throw new NotImplementedException();
    }

    public static Result<T> Fail(Exception error)
    {
        // TODO: Implement static factory method for failure result
        throw new NotImplementedException();
    }
}
