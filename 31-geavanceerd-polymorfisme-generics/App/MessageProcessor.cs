namespace App;

public class MessageProcessor<T> where T : IMessage
{
    public string LastProcessedPayload { get; private set; }
    public void Process(T message) 
    { 
        LastProcessedPayload = message.Payload;
    }
}
