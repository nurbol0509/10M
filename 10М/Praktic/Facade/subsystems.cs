using System;

public class RoomBookingSystem
{
    public void BookRoom()
    {
        Console.WriteLine("Номер забронирован.");
    }

    public void CheckAvailability()
    {
        Console.WriteLine("Проверка  номеров...");
    }

    public void CancelBooking()
    {
        Console.WriteLine("Бронирование номера отменено.");
    }
}

public class RestaurantSystem
{
    public void BookTable()
    {
        Console.WriteLine("Столик в ресторане забронирован.");
    }

    public void OrderFood(string food)
    {
        Console.WriteLine($"Заказано {food} из ресторана.");
    }
}

public class EventManagementSystem
{
    public void BookConferenceHall()
    {
        Console.WriteLine("Зал забронирован для мероприятия.");
    }

    public void OrderEquipment(string equipment)
    {
        Console.WriteLine($"{equipment} заказано для мероприятия.");
    }
}

public class CleaningService
{
    public void ScheduleCleaning()
    {
        Console.WriteLine("Уборка запланирована.");
    }

    public void RequestCleaning()
    {
        Console.WriteLine("Уборка запрошена.");
    }
}
