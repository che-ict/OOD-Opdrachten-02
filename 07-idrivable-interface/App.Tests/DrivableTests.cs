using App;

namespace App.Tests;

public class DrivableTests
{
    [Test]
    public void Car_Start_SetsIsRunningToTrue()
    {
        var car = new Car();
        car.Start();
        Assert.That(car.IsRunning, Is.True);
    }

    [Test]
    public void Car_Stop_SetsIsRunningToFalse()
    {
        var car = new Car();
        car.Start(); // Ensure it's running first
        car.Stop();
        Assert.That(car.IsRunning, Is.False);
    }
}
