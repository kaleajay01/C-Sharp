using System;

namespace DelegateDemo;

class Program
{
    static void sendEmail(string message)
    {
        Console.WriteLine("Email:"+message);
    }

    static void sendSMS(string message)
    {
        Console.WriteLine("SMS:"+message);
    }

    static void sendWhatsapp(string message)
    {
        Console.WriteLine("Whatsapp:"+message);
    }

    static void Main()
    {
        NotificationService service = new NotificationService();

        service.SendNotification("Your Order is shipped",sendEmail);
        // service.SendNotification("Your Order is shipped",sendSMS);
        // service.SendNotification("Your Order is shipped",sendWhatsapp);

    }    
}