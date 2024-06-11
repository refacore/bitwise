// See https://aka.ms/new-console-template for more information
using Bitwise;
using Bitwise.Notification;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var serviceCollection = new ServiceCollection();

// notification
serviceCollection.AddTransient<INotificationSender, EmailSender>();

serviceCollection.AddTransient<INotificationSender, SmsSender>();

serviceCollection.AddTransient<INotificationSender, MobileNotificationPusher>();

serviceCollection.AddSingleton<INotificationSenderFactory, NotificationSenderFactory>();

serviceCollection.AddTransient<NotificationService>();

var serviceProvider = serviceCollection.BuildServiceProvider();

// await NotificationTest.Run(serviceProvider);

// PermissionValidationTest.Run();

GameTest.Run();
