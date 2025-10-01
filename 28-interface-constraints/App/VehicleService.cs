namespace App;

public static class VehicleService
{
    public static void StartEngine<T>(T vehicle) where T : IDrivable
    {
        vehicle.Start();
    }
}
