namespace InheritanceLab;

public class SMSNotification : Notification
{
    // Конструктор просто передает параметры в базовый класс
    public SMSNotification(string phoneNumber, string message) 
        : base(phoneNumber, message)
    {
    }

    public override void Send()
    {
        Console.WriteLine($"[SMS] Сообщение на номер {Recipient}: \"{Message}\"");
    }
}