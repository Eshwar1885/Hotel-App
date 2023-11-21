namespace HotelApp.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        // Add other hotel details as needed
        public List<Room> Rooms { get; set; }
    }

}
