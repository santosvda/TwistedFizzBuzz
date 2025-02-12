using TwistedFizzBuzzLib;

var list = TwistedFizzBuzz.NormalFizzBuzz(1, 20);
var result = string.Join(",", list);

Console.WriteLine(result);