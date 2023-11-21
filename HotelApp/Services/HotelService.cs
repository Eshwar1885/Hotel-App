using HotelApp.Context;
using HotelApp.Interfaces;
using HotelApp.Models;
using HotelApp.Models.DTOs;

namespace HotelApp.Services
{
    public class HotelService : IHotelRepository
    {
        private readonly HotelDbContext _context;

        public HotelService(HotelDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public HotelDTO GetHotelById(int hotelId)
        {
            var hotel = _context.Hotels
                .Where(h => h.HotelId == hotelId)
                .Select(h => new HotelDTO
                {
                    HotelId = h.HotelId,
                    HotelName = h.HotelName,
                    Location = h.Location,
                    // Add other properties as needed
                })
                .FirstOrDefault();

            return hotel;
        }

        public List<HotelDTO> GetAllHotels()
        {
            var hotels = _context.Hotels
                .Select(h => new HotelDTO
                {
                    HotelId = h.HotelId,
                    HotelName = h.HotelName,
                    Location = h.Location,
                    // Add other properties as needed
                })
                .ToList();

            return hotels;
        }

        public void CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
        }

        public void UpdateHotel(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            _context.SaveChanges();
        }

        public void DeleteHotel(int hotelId)
        {
            var hotel = _context.Hotels.Find(hotelId);
            if (hotel != null)
            {
                _context.Hotels.Remove(hotel);
                _context.SaveChanges();
            }
        }

        public int GetAllRoomCount(int hotelId)
        {
            var roomCount = _context.Rooms.Count(r => r.HotelId == hotelId);
            return roomCount;
        }

        // Add more repository methods as needed
    }
}
