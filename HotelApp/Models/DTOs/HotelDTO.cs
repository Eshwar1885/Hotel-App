namespace HotelApp.Models.DTOs
{
    public class HotelDTO
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Location { get; set; }
        // Add other hotel details as needed
        public List<RoomDTO> Rooms { get; set; }
    }

}
