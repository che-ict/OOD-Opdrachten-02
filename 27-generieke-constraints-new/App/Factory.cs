namespace App;

public static class Factory
{
    public static T CreateInstance<T>() where T : new()
    {
        return new T();
    }
}
