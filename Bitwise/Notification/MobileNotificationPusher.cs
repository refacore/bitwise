namespace Bitwise.Notification;

public class MobileNotificationPusher : INotificationSender
{
    public NotificationChannels Channel => NotificationChannels.Mobile;

    public Task SendAsync(User user, Message message)
    {
        Console.WriteLine("send message via mobile channel");

        return Task.CompletedTask;
    }
}
