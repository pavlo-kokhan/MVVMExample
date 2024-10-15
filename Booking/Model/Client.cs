namespace Booking.Model;

public class Client
{
    public int ClientId { get; set; }
    public string FullName { get; set; } = null!;
    public string ContactEmail { get; set; } = null!;
    public string ContactNumber { get; set; } = null!;
}