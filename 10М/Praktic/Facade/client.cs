using System;

class Program
{
    static void Main(string[] args)
    {
        RoomBookingSystem roomBooking = new RoomBookingSystem();
        RestaurantSystem restaurant = new RestaurantSystem();
        EventManagementSystem eventManagement = new EventManagementSystem();
        CleaningService cleaning = new CleaningService();

        HotelFacade hotelFacade = new HotelFacade(roomBooking, restaurant, eventManagement, cleaning);

        hotelFacade.BookRoomWithServices();

        hotelFacade.OrganizeEventWithRoomAndEquipment();

        hotelFacade.BookRestaurantTableWithTaxi();

        hotelFacade.CancelAllBookings();

        hotelFacade.RequestRoomCleaning();
    }
}
