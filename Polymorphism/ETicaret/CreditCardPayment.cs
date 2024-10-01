namespace Polymorphism.ETicaret;

public class CreditCardPayment : BasePayment
{
    public string CardNumber { get; set; }
    public string CVV { get; set; }
    public string FullName { get; set; }

    public override void Pay()
    {
        Console.WriteLine($"Adınız : {FullName}, Tutar: {Amount}");
    }
}
