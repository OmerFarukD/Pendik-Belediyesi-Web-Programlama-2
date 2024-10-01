namespace Polymorphism.ETicaret;

public class IbanPayment : BasePayment
{

    public string AccountNo { get; set; }
    public override void Pay()
    {
        Console.WriteLine($"Hesap No: {AccountNo}, Tutar : {Amount}");
    }
}
