namespace App;

public class DatabaseLogger : ILoggable
{
    public string LastMessage { get; private set; }
    public void Log(string message) { LastMessage = message; }
}
