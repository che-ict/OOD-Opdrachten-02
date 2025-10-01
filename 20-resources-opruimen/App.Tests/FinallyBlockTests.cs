using App;
using System.Collections.Generic;

namespace App.Tests;

public class FinallyBlockTests
{
    [Test]
    public void ProcessResource_FinallyBlockAlwaysExecutes()
    {
        List<string> log = ResourceProcessor.ProcessResource();

        Assert.That(log.Count, Is.EqualTo(4));
        Assert.That(log[0], Is.EqualTo("Resource geopend"));
        Assert.That(log[1], Is.EqualTo("Data verwerkt"));
        Assert.That(log[2], Is.EqualTo("Fout afgehandeld"));
        Assert.That(log[3], Is.EqualTo("Resource vrijgegeven"));
    }
}
