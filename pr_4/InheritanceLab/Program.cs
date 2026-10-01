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
