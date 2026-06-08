public class Program
{
    static void CountTo100()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine($"CountTo100: {i}");
        }
    }
    static void CountTo1000()
    {
        for (int i = 1; i <= 1000; i++)
        {
            Console.WriteLine($"CountTo1000: {i}");
        }
    }

    public static void Main(string[] args)
    {
        // Run both functions in parallel
        Task t1 = Task.Run(() => CountTo100());
        Task t2 = Task.Run(() => CountTo1000());

        // Wait for both to finish
        Task.WaitAll(t1, t2);

        Console.WriteLine("Both tasks completed!");
    }


}
