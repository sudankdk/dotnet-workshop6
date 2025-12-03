namespace Task_2;
public delegate double Calculate(double a, double b);

public delegate double DiscountStrategy(double price);

class Program
{
    static double sum(double a, double b)=> a+b;
    static double subtract(double a, double b) => a - b;

    static double FestivalDiscount(double price) => 0.2 * price;
    static double SeasonalDiscount(double price) => 0.1 * price;
    static double NoDiscount(double price) => 0;

    static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
    {
        var dis=strategy(originalPrice);
        return originalPrice - dis;
    }

    
    
    static void Main(string[] args)
    {
        Calculate s = sum;
        Console.WriteLine($"The sum is {s(1,2)}");
        Calculate c = subtract;
        Console.WriteLine($"The subtract is {c(10,2)}");

        Console.WriteLine(CalculateFinalPrice(1000, FestivalDiscount));
        Console.WriteLine(CalculateFinalPrice(1000, SeasonalDiscount));
        Console.WriteLine(CalculateFinalPrice(1000, NoDiscount));
        Console.WriteLine(CalculateFinalPrice(1000, (double x=10000)=>0.3*x));

    }
}