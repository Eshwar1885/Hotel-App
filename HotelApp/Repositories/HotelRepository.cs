using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using HotelApp.Context;
using HotelApp.Models;

namespace HotelBookingSystem.Repositories
{
    public class HotelRepository : IHotelRepository<string, Hotel>
    {
        private readonly HotelDbContext _context;

        public HotelRepository(HotelDbContext context)
        {
            _context = context;
        }
        public Hotel Add(Hotel entity)
        {
            _context.Hotels.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Hotel Delete(string key)
        {
            var user = GetById(key);
            if (user != null)
            {
                _context.Hotels.Remove(user);
                _context.SaveChanges();
                return user;
            }
            return null;
        }

        public IList<Hotel> GetAll()
        {
            if (_context.Hotels.Count() == 0)
                return null;
            return _context.Hotels.ToList();
        }

        public Hotel GetById(string key)
        {
            var user = _context.Hotels.SingleOrDefault(u => u.Name == key);
            return user;
        }

        public Hotel Update(Hotel entity)
        {
            var hotel = GetById(entity.Name);
            if (hotel != null)
            {
                _context.Entry<Hotel>(hotel).State = EntityState.Modified;
                _context.SaveChanges();
                return hotel;
            }
            return null;
        }
    }
}