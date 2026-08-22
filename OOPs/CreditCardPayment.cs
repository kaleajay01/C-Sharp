using System;
namespace OOPDemo;

//inherit the Pay() abstract method
//abstract method implimentation 
public class CreditCardPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment done using credit card");
    }
}