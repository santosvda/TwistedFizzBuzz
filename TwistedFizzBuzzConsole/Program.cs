using TwistedFizzBuzzLib;

//Console.WriteLine("Twisted FizzBuzz: \n");
//var tokens =  new Dictionary<int, string> {
//            { 5, "Fizz" },
//            { 9, "Buzz" },
//            {27, "Bar" }
//        };
//var regular = TwistedFizzBuzz.TwistedFizzBuzzTokens(-20, 127, tokens);
//Console.WriteLine(string.Join(",", regular) + "\n");


Console.WriteLine("API Generated FizzBuzz: \n");
try
{
    var api = await TwistedFizzBuzz.ApiGeneratedTokensFizzBuzz(-20, 127);
    Console.WriteLine(string.Join(",", api) + "\n");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


