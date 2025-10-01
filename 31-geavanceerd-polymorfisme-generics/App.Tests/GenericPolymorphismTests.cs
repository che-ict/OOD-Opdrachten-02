using App;

namespace App.Tests;

public class GenericPolymorphismTests
{
    [Test]
    public void MessageProcessor_ProcessesEmailMessageCorrectly()
    {
        var processor = new MessageProcessor<EmailMessage>();
        processor.Process(new EmailMessage { Payload = "Hallo" });
        Assert.That(processor.LastProcessedPayload, Is.EqualTo("Hallo"));
    }

    [Test]
    public void MessageProcessor_ProcessesDifferentMessageTypes()
    {
        var processor = new MessageProcessor<SmsMessage>();
        processor.Process(new SmsMessage { Payload = "SMS Test" });
        Assert.That(processor.LastProcessedPayload, Is.EqualTo("SMS Test"));
    }
}

// Define another message type for testing
namespace App
{
    public class SmsMessage : IMessage { public string Payload { get; set; } }
}
