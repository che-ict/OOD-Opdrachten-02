using App;

namespace App.Tests;

public class CalculatorTests
{
    [Test]
    public void SafeDivide_DividesNormally_WhenNoZeroDivision()
    {
        Assert.That(Calculator.SafeDivide(10, 2), Is.EqualTo(5));
    }

    [Test]
    public void SafeDivide_ReturnsZero_WhenDividingByZero()
    {
        Assert.That(Calculator.SafeDivide(5, 0), Is.EqualTo(0));
    }

    [Test]
    public void SafeDivide_HandlesNegativeNumbersCorrectly()
    {
        Assert.That(Calculator.SafeDivide(-10, 2), Is.EqualTo(-5));
        Assert.That(Calculator.SafeDivide(10, -2), Is.EqualTo(-5));
        Assert.That(Calculator.SafeDivide(-10, -2), Is.EqualTo(5));
    }
}
