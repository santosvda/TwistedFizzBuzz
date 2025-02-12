using System.Diagnostics;
using TwistedFizzBuzzLib;

Console.WriteLine("===== Twisted FizzBuzz =====\n");

var tokens = new Dictionary<int, string>
        {
            { 5, "Fizz" },
            { 9, "Buzz" },
            { 27, "Bar" }
        };
var (start, end) = (-27, 127);

Console.WriteLine($"Generating FizzBuzz sequence from {start} to {end} with custom tokens...");
var stopwatch = Stopwatch.StartNew();
var twisted = TwistedFizzBuzz.TwistedFizzBuzzTokens(-20, 127, tokens);
stopwatch.Stop();

Console.WriteLine($"Result: {string.Join(", ", twisted)}");
Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms\n");

Console.WriteLine("===== API Generated FizzBuzz =====\n");
try
{
    Console.WriteLine("Fetching dynamic tokens from API...");
    stopwatch.Restart();
    var apiResult = await TwistedFizzBuzz.ApiGeneratedTokensFizzBuzz(-20, 127);
    stopwatch.Stop();
    Console.WriteLine($"API Result: {string.Join(", ", apiResult)}");
}
catch (Exception ex)
{
    Console.WriteLine($"API Error: {ex.Message}");
}

Console.WriteLine("===== Execution Complete =====");


