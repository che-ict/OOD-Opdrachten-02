using App;

namespace App.Tests;

public class ArgumentValidationTests
{
    [Test]
    public void ProcessName_ThrowsArgumentNullException_WhenNameIsNull()
    {
        var processor = new Processor();
        Assert.Throws<ArgumentNullException>(() => processor.ProcessName(null));
    }

    [Test]
    public void ProcessName_DoesNotThrowException_WhenNameIsNotNull()
    {
        var processor = new Processor();
        Assert.DoesNotThrow(() => processor.ProcessName("Alice"));
    }
}
