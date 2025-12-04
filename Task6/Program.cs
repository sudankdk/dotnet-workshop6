namespace Task6;

class Program
{
    static void Main(string[] args)
    {
            Booking b1 = new Booking("John", "Paris", 15000, 7, true);
            Booking b2 = new Booking("Sarah", "Goa", 8000, 5, false);
            Booking b3 = new Booking("Mike", "New York", 25000, 10, true);
            Booking b4 = new Booking("Emma", "Kerala", 12000, 6, false);
            Booking b5 = new Booking("David", "Tokyo", 30000, 8, true);
            Booking b6 = new Booking("Lisa", "Mumbai", 11000, 7, false);
            Booking b7 = new Booking("Alice", "London", 10500, 3, true);
            Booking b8 = new Booking("Bob", "Chennai", 7000, 5, false);

            List<Booking> allBookings = new List<Booking> { b1, b2, b3, b4, b5, b6, b7, b8 };

            var filtered = allBookings
                .Where(b => b.Price > 10000 && b.DurationInDays > 4)
                .ToList();
          

            var transformed = filtered
                .Select(b => new
                {
                    b.CustomerName,
                    b.Destination,
                    Category = b.IsInternational ? "International" : "Domestic",
                    b.Price,
                    b.DurationInDays
                })
                .ToList();

            var result = transformed
                .OrderBy(x => x.Category)
                .ThenBy(x => x.Price)
                .ToList();

            Console.WriteLine("Travel Company Report\n");
            Console.WriteLine("Customer\tDestination\tCategory\t\tPrice\tDuration");
            Console.WriteLine("--------\t-----------\t--------\t\t-----\t--------");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.CustomerName}\t\t{item.Destination}\t\t{item.Category}\t\tRs.{item.Price}\t{item.DurationInDays} days");
            }

            Console.WriteLine($"\nTotal tours in report: {result.Count}");
    }
}