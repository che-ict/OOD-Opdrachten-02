namespace App;

public class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override string MakeSound() => "Woef!";
}
