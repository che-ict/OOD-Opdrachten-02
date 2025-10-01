namespace App;

public interface ILoggable
{
    void Log(string message);
    string LastMessage { get; }
}
