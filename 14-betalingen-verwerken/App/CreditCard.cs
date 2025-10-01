namespace App;

public class CreditCard : IPayable {
    public decimal TotalPaid { get; private set; }
    public void ProcessPayment(decimal amount) { TotalPaid += amount; }
}
