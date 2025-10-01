using App;

namespace App.Tests;

public class ContravarianceTests
{
    [Test]
    public void IConsumer_Contravariance_AllowsAssignmentFromBaseToDerivedType()
    {
        IConsumer<Animal> animalConsumer = new AnimalConsumer();
        IConsumer<Dog> dogConsumer = animalConsumer; // Contravariantie
        var myDog = new Dog("een hond");
        dogConsumer.Consume(myDog);

        // We need to cast animalConsumer back to AnimalConsumer to access LastConsumed
        Assert.That((animalConsumer as AnimalConsumer).LastConsumed, Is.SameAs(myDog));
    }
}
