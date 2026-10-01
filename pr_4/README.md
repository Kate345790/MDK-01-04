# Практическая работа № 4: Реализация наследования и виртуальных методов

**Вариант:** 8
**Студент:** Дубровина Е.А.

## Задание
Уведомления: Notification (базовый), EmailNotification, SMSNotification, PushNotification. Виртуальный метод Send().

## Код программы
```csharp
using InheritanceLab;

List<Notification> notifications = 
[
    new EmailNotification("dubrovina.ekaterina291107@gmail.com", "Результаты лабораторной", "Ваша работа оценена на 5."),
    new SMSNotification("+7-999-123-45-67", "Код подтверждения: 4829"),
    new PushNotification("DEVICE-TOKEN-A83F1", "Новое сообщение в чате группы"),
    new EmailNotification("support@company.com", "Тикет #104", "Ваш запрос принят в работу.")
];

Console.WriteLine("Отправка всех уведомлений через единый интерфейс базового класса:");
Console.WriteLine("------------------------------------------------------------------");

foreach (Notification item in notifications)
{
    item.Send();
    Console.WriteLine();
}
```

### Базовый класс (Notification)

```csharp
namespace InheritanceLab;

public class Notification
{
    public string Recipient { get; set; }
    public string Message { get; set; }
    public Notification(string recipient, string message)
    {
        Recipient = recipient;
        Message = message;
    }
    public virtual void Send()
    {
        Console.WriteLine($"[Базовое уведомление] Отправка сообщения '{Message}' для {Recipient}");
    }
}
```

### Производный класс (Car.cs)

```csharp
public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Двигатель автомобиля запущен.");
    }
}
```

*(Аналогично для Bicycle и Motorcycle)*

### Основной код программы (Program.cs)

```csharp
List<Vehicle> vehicles = [new Car(), new Bicycle(), new Motorcycle(), new Car()];

Console.WriteLine("Запуск двигателей:");
foreach (Vehicle v in vehicles)
{
    v.StartEngine();
}
```

## Скриншоты

![Результат работы программы](images/screenshot1.png)