namespace Task_2;
public delegate double Calculate(double a, double b);

class Program
{
    static double sum(double a, double b)=> a+b;
    static double subtract(double a, double b) => a - b;
    static void Main(string[] args)
    {
        Calculate s = sum;
        Console.WriteLine($"The sum is {s(1,2)}");
        Calculate c = subtract;
        Console.WriteLine($"The subtract is {c(10,2)}");
    }
}