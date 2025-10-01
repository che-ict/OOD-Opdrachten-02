namespace App;

public class AnimalConsumer : IConsumer<Animal>
{
    public Animal LastConsumed { get; private set; }

    public void Consume(Animal item)
    {
        // TODO: Implement the Consume method to set LastConsumed
        throw new NotImplementedException();
    }
}
