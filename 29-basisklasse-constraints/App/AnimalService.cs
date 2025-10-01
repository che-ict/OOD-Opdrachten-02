namespace App;

public static class AnimalService
{
    public static string GetAnimalName<T>(T animal) where T : Animal
    {
        return animal.Name;
    }
}
