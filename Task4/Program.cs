namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        numbers.Select(n=>n*2).ToList().ForEach(n=>Console.WriteLine(n));
        
        List<Books> books = new List<Books> 
        {
            new Books { Title="book1", Price=800 },
            new Books { Title="book2", Price=1500 },
            new Books { Title="book3", Price=2000 },
            new Books { Title="book4", Price=900 }
        };
        var premiumBooks = books.Where(b => b.Price > 1000).ToList();
        Console.WriteLine("\nBooks priced above Rs.1000:");
        foreach (var book in premiumBooks)
            Console.WriteLine($"{book.Title} - Rs.{book.Price}");
        
        List<Students> students = new List<Students> //---list of student objects
        {
            new Students { Name="RAM" },
            new Students { Name="Sita" },
            new Students { Name="Rahul" },
            new Students { Name="gita" },
            new Students { Name="Shreya" },
            new Students { Name="Laxmi" },
            new Students { Name="Dinesh" },
            new Students { Name="Ajay" },
            new Students { Name="Sandesh" },
            new Students { Name="aalu" }
        };

        var sortedStudents = students.OrderBy(s => s.Name).ToList();

        Console.WriteLine("\nStudents Sorted Alphabetically for AAA:");
        foreach (var s in sortedStudents)
        {
            Console.WriteLine(s.Name);
        } 
        
    }
    
    
}

class Books
{
    public string Title { get; set; }
    public int Price { get; set; }
}


class Students
{
    public string Name { get; set; }
}