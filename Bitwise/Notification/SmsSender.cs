namespace Bitwise.Notification;

public class SmsSender : INotificationSender
{
    public NotificationChannels Channel => NotificationChannels.Sms;

    public Task SendAsync(User user, Message message)
    {
        Console.WriteLine("send message via sms channel");

        return Task.CompletedTask;
    }
}
