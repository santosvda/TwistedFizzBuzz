using TwistedFizzBuzzLib;

Console.WriteLine("Twisted FizzBuzz: \n");
var tokens =  new Dictionary<int, string> {
            { 5, "Fizz" },
            { 9, "Buzz" },
            {27, "Bar" }
        };
var regular = TwistedFizzBuzz.TwistedFizzBuzzTokens(-20, 127, tokens);
Console.WriteLine(string.Join(",", regular) + "\n");

