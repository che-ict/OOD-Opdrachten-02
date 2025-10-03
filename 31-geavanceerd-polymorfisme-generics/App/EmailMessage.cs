namespace App;

public class EmailMessage : IMessage
{
    public EmailMessage(string payload){Payload=payload;}
    public string Payload {get;private set;}
}
