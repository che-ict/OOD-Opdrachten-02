namespace App;

public class FileLogger : ILoggable
{
    public string LastMessage { get; private set; }
    public void Log(string message) { LastMessage = message; }
}
