namespace App;

public class PayPal : IPayable {
    public decimal TotalPaid { get; private set; }
    public void ProcessPayment(decimal amount) { TotalPaid += amount; }
}
