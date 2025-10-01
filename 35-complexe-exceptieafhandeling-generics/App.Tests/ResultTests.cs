using App;

namespace App.Tests;

public class ResultTests
{
    [Test]
    public void OkResult_IsSuccess_IsTrue_AndValueIsCorrect()
    {
        var success = Result<int>.Ok(10);
        Assert.That(success.IsSuccess, Is.True);
        Assert.That(success.Value, Is.EqualTo(10));
        Assert.That(success.Error, Is.Null);
    }

    [Test]
    public void FailResult_IsSuccess_IsFalse_AndErrorIsNotNull()
    {
        var failure = Result<int>.Fail(new Exception("Fout"));
        Assert.That(failure.IsSuccess, Is.False);
        Assert.That(failure.Value, Is.EqualTo(default(int))); // Value should be default for failed result
        Assert.That(failure.Error, Is.Not.Null);
        Assert.That(failure.Error.Message, Is.EqualTo("Fout"));
    }

    [Test]
    public void FailResult_WithDifferentExceptionType_WorksCorrectly()
    {
        var failure = Result<string>.Fail(new ArgumentException("Ongeldig argument"));
        Assert.That(failure.IsSuccess, Is.False);
        Assert.That(failure.Value, Is.Null); // Value should be default for failed result (null for string)
        Assert.That(failure.Error, Is.Not.Null);
        Assert.That(failure.Error, Is.InstanceOf<ArgumentException>());
    }
}
