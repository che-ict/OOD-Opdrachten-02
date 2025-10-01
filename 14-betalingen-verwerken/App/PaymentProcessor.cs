using System.Collections.Generic;

namespace App;

public static class PaymentProcessor
{
    public static void ProcessAllPayments(List<IPayable> payables, decimal amount)
    {
        foreach (var payable in payables)
        {
            payable.ProcessPayment(amount);
        }
    }
}
