namespace InheritanceLab;

public class Notification
{
    // Свойства, общие для всех типов уведомлений
    public string Recipient { get; set; }
    public string Message { get; set; }

    // Конструктор базового класса
    public Notification(string recipient, string message)
    {
        Recipient = recipient;
        Message = message;
    }

    // Ключевое слово virtual разрешает классам-потомкам переопределять этот метод
    public virtual void Send()
    {
        Console.WriteLine($"[Базовое уведомление] Отправка сообщения '{Message}' для {Recipient}");
    }
}