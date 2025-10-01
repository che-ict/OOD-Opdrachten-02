namespace App;

public class MessageProcessor<T> where T : IMessage
{
    public string LastProcessedPayload { get; private set; }

    public void Process(T message)
    {
        // TODO: Implement the Process method to set LastProcessedPayload from the message
        throw new NotImplementedException();
    }
}
