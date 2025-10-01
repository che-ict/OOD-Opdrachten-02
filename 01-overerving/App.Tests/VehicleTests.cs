using App;

namespace App.Tests;

public class VehicleTests
{
    [Test]
    public void Car_Test()
    {
        var myCar = new Car { Speed = 180, Color = "Red", NumberOfDoors = 4 };
        Assert.That(myCar.Speed, Is.EqualTo(180));
        Assert.That(myCar.Color, Is.EqualTo("Red"));
        Assert.That(myCar.NumberOfDoors, Is.EqualTo(4));
    }

    [Test]
    public void Motorcycle_Test()
    {
        var myBike = new Motorcycle { Speed = 120, Color = "Black", HasSidecar = false };
        Assert.That(myBike.Speed, Is.EqualTo(120));
        Assert.That(myBike.Color, Is.EqualTo("Black"));
        Assert.That(myBike.HasSidecar, Is.EqualTo(false));
    }
}
