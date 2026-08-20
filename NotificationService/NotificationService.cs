namespace DelegateDemo;

public class NotificationService
{
    public void SendNotification(string message, NotificationHandler handler)
    {
        handler(message);
    }
}