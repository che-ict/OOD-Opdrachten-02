namespace App;

public class AnimalConsumer : IConsumer<Animal> 
{ 
    public Animal LastConsumed { get; private set; }
    public void Consume(Animal item) { LastConsumed = item; }
}
