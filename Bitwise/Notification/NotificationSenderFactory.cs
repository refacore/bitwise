using Microsoft.Extensions.DependencyInjection;

namespace Bitwise.Notification;

public interface INotificationSenderFactory
{
    INotificationSender GetSender(NotificationChannels channel);

    IEnumerable<INotificationSender> GetSenders(NotificationChannels channels);
}

public class NotificationSenderFactory : INotificationSenderFactory
{
    private readonly IServiceProvider serviceProvider;

    public NotificationSenderFactory(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public INotificationSender GetSender(NotificationChannels channel)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INotificationSender> GetSenders(NotificationChannels channels)
    {
        var senders = this.serviceProvider.GetServices<INotificationSender>();

        if (channels == NotificationChannels.All)
        {
            return senders;
        }

        return senders.Where(sender => (sender.Channel & channels) == sender.Channel);
    }
}
