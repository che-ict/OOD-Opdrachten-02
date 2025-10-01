using App;

namespace App.Tests;

public class CovarianceTests
{
    [Test]
    public void IProducer_Covariance_AllowsAssignmentFromDerivedToBasetype()
    {
        IProducer<Dog> dogProducer = new DogProducer();
        IProducer<Animal> animalProducer = dogProducer; // Covariantie
        var producedAnimal = animalProducer.Produce();

        Assert.That(producedAnimal, Is.InstanceOf<Dog>());
        Assert.That(producedAnimal.Name, Is.EqualTo("een hond"));
    }
}
