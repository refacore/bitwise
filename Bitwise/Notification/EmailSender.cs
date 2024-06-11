namespace Bitwise.Notification;

public class EmailSender : INotificationSender
{
    public NotificationChannels Channel => NotificationChannels.Email;

    public Task SendAsync(User user, Message message)
    {
        return SendAsyncInternal(message.Content, message.Title ?? "No reply", "no-reply@refacore.com", user.Identity.Email);
    }

    private Task SendAsyncInternal(string body, string subject, string sender, string reciever)
    {
        Console.WriteLine("send message via email channel");

        return Task.CompletedTask;
    }
}
