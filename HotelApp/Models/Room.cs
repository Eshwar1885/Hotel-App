using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        // Add other room details as needed
        public int HotelId { get; set; }
        [ForeignKey("Hotel")]
        public Hotel Hotel { get; set; }
    }


}
