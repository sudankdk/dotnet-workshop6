namespace Task6;

public class Booking
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public decimal Price { get; set; }
    public int DurationInDays { get; set; }
    public bool IsInternational { get; set; }

    public Booking(string name, string destination, decimal price, int days, bool isInternational)
    {
        CustomerName = name;
        Destination = destination;
        Price = price;
        DurationInDays = days;
        IsInternational = isInternational;
    }
}