using System.Reflection;
using System.Xml;
using App;

namespace App.Tests;

public class GenericPolymorphismTests
{

    [Test]
    public void MessageProcessor_GenericLimitsIMessage()
    {
        var processorType = typeof(MessageProcessor<>);
        Type[] constraints = processorType.GetGenericArguments()[0].GetGenericParameterConstraints();
        Assert.That(constraints.All(constraint => constraint.IsAssignableFrom(typeof(EmailMessage))), Is.True);
        Assert.That(constraints.All(constraint => constraint.IsAssignableFrom(typeof(SmsMessage))), Is.True);
        Assert.That(constraints.Any(constraint => constraint.IsAssignableFrom(typeof(Exception))), Is.False);
    }
    
    [Test]
    public void MessageProcessor_ProcessesEmailMessageCorrectly()
    {
        var processor = new MessageProcessor<EmailMessage>();
        processor.Process(new EmailMessage ("Hallo"));
        Assert.That(processor.LastProcessedPayload, Is.EqualTo("Hallo"));
    }
    
    [Test]
    public void MessageProcessor_ProcessesDifferentMessageTypes()
    {
        var processor = new MessageProcessor<SmsMessage>();
        processor.Process(new SmsMessage { Payload = "SMS Test" });
        Assert.That(processor.LastProcessedPayload, Is.EqualTo("SMS Test"));
    }
    
    [Test]
    public void MessageProcessor_ProcessesMultipleMessages()
    {
        var processor = new MessageProcessor<SmsMessage>();
        processor.Process(new SmsMessage { Payload = "SMS Test" });
        processor.Process(new SmsMessage { Payload = "SMS Test 2" });
        Assert.That(processor.LastProcessedPayload, Is.EqualTo("SMS Test 2"));
    }
}

public class SmsMessage : IMessage { public string Payload { get; set; } }
