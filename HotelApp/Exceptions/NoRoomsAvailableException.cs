namespace HotelApp.Exceptions
{
    public class NoRoomsAvailableException : Exception
    {
        string message;
        public NoRoomsAvailableException()
        {
            message = "No rooms are available!!";
        }
        public override string Message => message;
    }
}
