namespace App;

public class Person
{
    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            // TODO: Implement age validation and throw InvalidAgeException if age is invalid
            _age = value;
        }
    }
}
