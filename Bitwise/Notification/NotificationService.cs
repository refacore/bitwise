namespace Bitwise.Notification;

public class NotificationService
{
    private readonly INotificationSenderFactory notificationSenderFactory;

    public NotificationService(INotificationSenderFactory notificationSenderFactory)
    {
        this.notificationSenderFactory = notificationSenderFactory;
    }

    public Task SendNotification(User user, Message message)
    {
        var senders = notificationSenderFactory.GetSenders(user.Settings.NotificationChannels);

        return Task.WhenAll(senders.Select(sender => sender.SendAsync(user, message)).ToArray());
    }
}
