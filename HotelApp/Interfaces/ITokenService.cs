using HotelApp.Models.DTOs;

namespace HotelApp.Interface
{
    public interface ITokenService
    {
        string GetToken(HotelDTO user);
    }
}
