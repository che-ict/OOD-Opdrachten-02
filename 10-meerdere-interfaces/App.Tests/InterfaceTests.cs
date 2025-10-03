using App;

namespace App.Tests;

public class InterfaceTests
{
    [Test]
    public void JsonProcessor_Deserialize_SetsDataCorrectly()
    {
        var processor = new JsonProcessor();
        processor.Deserialize("{\"Data\":\"Hello World\"}");
        Assert.That(processor.Data, Is.EqualTo("Hello World"));
    }

    [Test]
    public void JsonProcessor_Serialize_ReturnsCorrectFormat()
    {
        var processor = new JsonProcessor();
        processor.Deserialize("{\"Data\":\"This is test data\"}");
        Assert.That(processor.Serialize(), Is.EqualTo("{\"Data\":\"This is test data\"}"));
    }
}
