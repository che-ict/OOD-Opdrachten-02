namespace App;

public class DogProducer : IProducer<Dog> { public Dog Produce() => new Dog("een hond"); }
