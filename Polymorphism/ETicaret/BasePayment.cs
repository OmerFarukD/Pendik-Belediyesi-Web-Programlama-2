namespace Polymorphism.ETicaret;

public  abstract class BasePayment
{
    public double Amount { get; set; }


    public abstract void Pay();

}
