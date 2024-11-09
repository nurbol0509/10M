using System;

public class HotelFacade
{
    private RoomBookingSystem _roomBookingSystem;
    private RestaurantSystem _restaurantSystem;
    private EventManagementSystem _eventManagementSystem;
    private CleaningService _cleaningService;

    public HotelFacade(RoomBookingSystem roomBooking, RestaurantSystem restaurant,
                       EventManagementSystem eventManagement, CleaningService cleaning)
    {
        _roomBookingSystem = roomBooking;
        _restaurantSystem = restaurant;
        _eventManagementSystem = eventManagement;
        _cleaningService = cleaning;
    }

    public void BookRoomWithServices()
    {
        Console.WriteLine("Бронирование номера с услугами ресторана и уборки...");
        _roomBookingSystem.BookRoom();
        _restaurantSystem.OrderFood("Ужин в номер");
        _cleaningService.ScheduleCleaning();
        Console.WriteLine("Номер с услугами забронирован.\n");
    }

    public void OrganizeEventWithRoomAndEquipment()
    {
        Console.WriteLine("Организация мероприятия с оборудованием и бронированием номеров...");
        _eventManagementSystem.BookConferenceHall();
        _eventManagementSystem.OrderEquipment("Проектор и звуковая система");
        _roomBookingSystem.BookRoom();
        Console.WriteLine("Мероприятие организовано.\n");
    }

    public void BookRestaurantTableWithTaxi()
    {
        Console.WriteLine("Бронирование столика в ресторане с вызовом такси...");
        _restaurantSystem.BookTable();
        Console.WriteLine("Такси вызвано для транспорта.\n");
    }

    public void CancelAllBookings()
    {
        Console.WriteLine("Отмена всех бронирований...");
        _roomBookingSystem.CancelBooking();
        Console.WriteLine("Все бронирования отменены.\n");
    }

    public void RequestRoomCleaning()
    {
        Console.WriteLine("Запрос на уборку номера...");
        _cleaningService.RequestCleaning();
        Console.WriteLine("Уборка номера запрошена.\n");
    }
}
