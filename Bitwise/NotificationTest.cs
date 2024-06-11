using Bitwise.Notification;
using Microsoft.Extensions.DependencyInjection;

namespace Bitwise;

public static class NotificationTest
{
    public static async Task Run(IServiceProvider serviceProvider)
    {
        var message = new Message
        {
            Title = "test message",
            Content = "test message content"
        };

        // notification test
        var user = new User
        {
            Identity = new Identity
            {
                Email = "test@refacore.com",
                MobileNumber = "0123456789",
                DeviceId = "refacore_device",
            },
            Settings = new UserSettings
            {
                NotificationChannels = NotificationChannels.Email | NotificationChannels.Sms
            }
        };

        var notificationService = serviceProvider.GetService<NotificationService>();

        await notificationService!.SendNotification(user, message);
    }
}
