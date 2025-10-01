namespace App;

public class Result<T>
{
    public T Value { get; }
    public Exception Error { get; }
    public bool IsSuccess => Error == null;

    private Result(T value) { Value = value; }
    private Result(Exception error) { Error = error; }

    public static Result<T> Ok(T value) => new Result<T>(value);
    public static Result<T> Fail(Exception error) => new Result<T>(error);
}
