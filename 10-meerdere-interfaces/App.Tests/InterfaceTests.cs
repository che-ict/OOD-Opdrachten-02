using App;

namespace App.Tests;

public class InterfaceTests
{
    [Test]
    public void JsonProcessor_Deserialize_SetsDataCorrectly()
    {
        var processor = new JsonProcessor();
        processor.Deserialize("{}");
        Assert.That(processor.Data, Is.EqualTo("Geparsed"));
    }

    [Test]
    public void JsonProcessor_Serialize_ReturnsCorrectFormat()
    {
        var processor = new JsonProcessor();
        processor.Deserialize("some data"); // Set some data first
        // The example shows {{'Data':'{Data}'}}, so I'll test for that.
        Assert.That(processor.Serialize(), Is.EqualTo("{'Data':'Geparsed'}"));
    }
}
