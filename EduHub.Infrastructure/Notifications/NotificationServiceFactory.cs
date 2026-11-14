using System;
using EduHub.Application.Interfaces;

namespace EduHub.Infrastructure.Notifications;

public class NotificationServiceFactory : INotificationServiceFactory
{
    public INotificationService GetNotificationService(string channel)
    {
        return channel?.Trim().ToLowerInvariant() switch
        {
            "sms" => new SmsNotificationService(),
            "email" => new EmailNotificationService(),
            _ => new EmailNotificationService()
        };
    }
}
