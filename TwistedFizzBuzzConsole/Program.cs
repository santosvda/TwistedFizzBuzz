using TwistedFizzBuzzLib;

var list = TwistedFizzBuzz.RegularFizzBuzz(1, 10);
var result = string.Join(",", list);

Console.WriteLine(result);