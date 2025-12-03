namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 55, 77, 44, 86, 33 };

        Console.WriteLine("Even Numbers:");
        ProcessNumbers(numbers, n => n % 2 == 0);

        Console.WriteLine("\nNumbers Greater Than 10:");
        ProcessNumbers(numbers, n => n > 10);
    }


    static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (int n in numbers)
        {
            if (condition(n))
            {
                Console.WriteLine(n);
            }
        }
    }
}