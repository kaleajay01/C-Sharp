namespace OOPDemo;

public class UPIPayment : Payment
{
    //abstract method implimentation
    public override void Pay()
    {
        Console.WriteLine("Payment done using UPI");
    }
}