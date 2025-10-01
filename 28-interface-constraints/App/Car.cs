namespace App;

public class Car : IDrivable
{
    public bool IsRunning { get; private set; }
    public void Start() { IsRunning = true; }
    public void Stop() { IsRunning = false; }
}
