using System.Diagnostics;
using TwistedFizzBuzzLib;

Console.WriteLine("===== Regular FizzBuzz =====\n");

RunRegularFizzBuzz();
RunNonSequentialFizzBuzz();

Console.WriteLine("\n===== Execution Complete =====");

static void RunRegularFizzBuzz()
{
    var (start, end) = (1, 100);
    Console.WriteLine($"Regular FizzBuzz ({start} to {end}):\n");

    var stopwatch = Stopwatch.StartNew();
    var regular = TwistedFizzBuzz.RegularFizzBuzz(1, 100);
    stopwatch.Stop();

    Console.WriteLine($"Result: {string.Join(", ", regular)}");
    Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms\n");
}

static void RunNonSequentialFizzBuzz()
{
    Console.WriteLine("Non-Sequential FizzBuzz:\n");

    int[] numbers = { 1, 4, -12, -5, 6, 300, 12, 15 };

    var stopwatch = Stopwatch.StartNew();
    var nonSequential = TwistedFizzBuzz.NonSequentialFizzBuzz(numbers);
    stopwatch.Stop();

    Console.WriteLine($"Input: {string.Join(", ", numbers)}");
    Console.WriteLine($"Result: {string.Join(", ", nonSequential)}");
    Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms\n");
}
