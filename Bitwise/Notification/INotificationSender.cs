namespace Bitwise.Notification;

public interface INotificationSender
{
    NotificationChannels Channel { get; }
    Task SendAsync(User user, Message message);
}
