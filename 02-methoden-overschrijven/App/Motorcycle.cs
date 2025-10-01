namespace App;

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override string DisplayInfo()
    {
        return base.DisplayInfo() + $", Met zijspan: {HasSidecar}";
    }
}
