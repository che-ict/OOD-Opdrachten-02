namespace App;

public class Person
{
    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 || value > 120)
            {
                throw new InvalidAgeException("Leeftijd moet tussen 0 en 120 zijn.");
            }
            _age = value;
        }
    }
}
