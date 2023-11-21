using HotelApp.Models.DTOs;

namespace HotelApp.Interface
{
    public interface IUserService
    {
        HotelDTO Login(HotelDTO userDTO);
        HotelDTO Register(HotelDTO userDTO);
    }
}
