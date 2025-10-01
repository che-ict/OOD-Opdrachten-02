namespace App;

public interface IPayable {
    void ProcessPayment(decimal amount);
    decimal TotalPaid { get; }
}
