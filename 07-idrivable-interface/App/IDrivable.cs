namespace App;

public interface IDrivable
{
    bool IsRunning { get; }
    void Start();
    void Stop();
}
