using System;
namespace OOPDemo;

class Program
{
    static void Main(String[] args)
    {

        //object creation
        Payment payment1 = new UPIPayment();
        payment1.Pay();

        Payment payment2 = new CreditCardPayment();
        payment2.Pay();
    }
}