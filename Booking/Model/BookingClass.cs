namespace Booking.Model;

public class BookingClass
{
    public int BookingId { get; set; }
    public string ServiceName { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsConfirmed { get; set; }
}