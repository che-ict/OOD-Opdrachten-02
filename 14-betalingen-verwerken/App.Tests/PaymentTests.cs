using App;

namespace App.Tests;

public class PaymentTests
{
    [Test]
    public void CreditCard_ProcessesPaymentCorrectly()
    {
        var creditCard = new CreditCard();
        PaymentProcessor.ProcessAllPayments(new List<IPayable> { creditCard }, 100);
        Assert.That(creditCard.TotalPaid, Is.EqualTo(100));
    }

    [Test]
    public void PayPal_ProcessesPaymentCorrectly()
    {
        var payPal = new PayPal();
        PaymentProcessor.ProcessAllPayments(new List<IPayable> { payPal }, 50);
        Assert.That(payPal.TotalPaid, Is.EqualTo(50));
    }

    [Test]
    public void MultiplePayables_ProcessPaymentsCorrectly()
    {
        var creditCard = new CreditCard();
        var payPal = new PayPal();
        var payables = new List<IPayable> { creditCard, payPal };

        PaymentProcessor.ProcessAllPayments(payables, 75);

        Assert.That(creditCard.TotalPaid, Is.EqualTo(75));
        Assert.That(payPal.TotalPaid, Is.EqualTo(75));
    }
}
