namespace Bitwise.Notification;

public class User
{
    public Identity Identity { get; set; } = new Identity();

    public UserSettings Settings { get; set; } = new UserSettings { NotificationChannels = NotificationChannels.Email };
}
