namespace App;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public override string DisplayInfo()
    {
        return base.DisplayInfo() + $", Deuren: {NumberOfDoors}";
    }
}
