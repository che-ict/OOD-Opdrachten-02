using App;

namespace App.Tests;

public class VehicleTests
{
    [Test]
    public void Car_DisplayInfo_Test()
    {
        var myCar = new Car { Speed = 180, Color = "Red", NumberOfDoors = 4 };
        Assert.That(myCar.DisplayInfo(), Does.Contain("Deuren: 4"));
    }

    [Test]
    public void Motorcycle_DisplayInfo_Test()
    {
        var myBike = new Motorcycle { Speed = 120, Color = "Black", HasSidecar = true };
        Assert.That(myBike.DisplayInfo(), Does.Contain("Met zijspan: True"));
    }
}
