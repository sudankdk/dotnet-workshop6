namespace task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Rectangle rectangle = new Rectangle();
       var l= rectangle.Length = 20;
        var b=rectangle.Breadth = 20;
        double ans=rectangle.Area(l, b);
        Console.WriteLine($"The area is {ans}");
        double perimeter=rectangle.Perimeter(l, b);
        Console.WriteLine($"The perimeter is {perimeter}");
    }
}


class Rectangle
{
    private double length;
    private double breadth;

    public double Length
    {
        get => length;
        set => length = value; 
    }

    public double Breadth
    {
        get => breadth;
        set => breadth = value;
    }



   public  double Area(double l, double b) => l * b;

   public  double Perimeter(double l, double b) =>l + 2 * b;
  
}