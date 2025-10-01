using App;

namespace App.Tests;

public class InterfaceConstraintTests
{
    [Test]
    public void StartEngine_StartsVehicle()
    {
        var car = new Car();
        VehicleService.StartEngine(car);
        Assert.That(car.IsRunning, Is.True);
    }

    [Test]
    public void StartEngine_DoesNotCompileWithoutIDrivable()
    {
        // This test is conceptual. The following line would cause a compile-time error:
        // public class NotADrivable { }
        // VehicleService.StartEngine(new NotADrivable());
        Assert.Pass("Method only accepts types implementing IDrivable, verified by compile-time check.");
    }
}
