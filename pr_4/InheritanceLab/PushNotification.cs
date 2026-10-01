namespace InheritanceLab;

public class PushNotification : Notification
{
    public string DeviceToken { get; set; }

    public PushNotification(string deviceToken, string message) 
        : base(deviceToken, message)
    {
        DeviceToken = deviceToken;
    }

    public override void Send()
    {
        Console.WriteLine($"[Push] Всплывающее уведомление на устройство {DeviceToken}: \"{Message}\"");
    }
}