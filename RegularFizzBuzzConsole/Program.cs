using TwistedFizzBuzzLib;

Console.WriteLine("Regular FizzBuzz: \n");
var regular = TwistedFizzBuzz.RegularFizzBuzz(1, 20);
Console.WriteLine(string.Join(",", regular) + "\n");

Console.WriteLine("Non-sequential FizzBuzz: \n");
var nonSequential = TwistedFizzBuzz.NonSequentialFizzBuzz(new int[] { 1, 4, -12, -5, 6, 300, 12, 15 });
Console.WriteLine(string.Join(",", nonSequential));

