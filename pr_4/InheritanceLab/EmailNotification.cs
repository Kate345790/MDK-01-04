namespace InheritanceLab;

public class EmailNotification : Notification
{
    // Уникальное свойство только для email
    public string Subject { get; set; }

    // Вызываем конструктор базового класса с помощью : base(...)
    public EmailNotification(string recipient, string subject, string message) 
        : base(recipient, message)
    {
        Subject = subject;
    }

    // Переопределение метода
    public override void Send()
    {
        Console.WriteLine($"[Email] Письмо на адрес <{Recipient}>.");
        Console.WriteLine($"        Тема: \"{Subject}\"");
        Console.WriteLine($"        Текст: \"{Message}\"");
    }
}