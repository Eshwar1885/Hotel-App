using HotelApp.Models.DTOs;
using HotelApp.Models;

namespace HotelApp.Interfaces
{
    public interface IHotelRepository
    {
        HotelDTO GetHotelById(int hotelId);
        List<HotelDTO> GetAllHotels();
        void CreateHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void DeleteHotel(int hotelId);

        int GetAvailableRoomCount(int hotelId);
        object GetById(string username);
        // Add more repository methods as needed
    }
}
