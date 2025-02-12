using TwistedFizzBuzzLib;

var list = TwistedFizzBuzz.RegularFizzBuzz(1, 20);
var result = string.Join(",", list);

Console.WriteLine(result);