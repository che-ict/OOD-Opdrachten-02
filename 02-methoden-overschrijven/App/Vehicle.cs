namespace App;

public class Vehicle
{
    public double Speed { get; set; }
    public string Color { get; set; }

    public virtual string DisplayInfo()
    {
        return $"Kleur: {Color}, Snelheid: {Speed} km/u";
    }
}
