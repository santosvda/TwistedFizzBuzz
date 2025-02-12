namespace TwistedFizzBuzzLib
{
    public static class TwistedFizzBuzz
    {
        private static readonly Dictionary<int, string> defautlTokens =
        new Dictionary<int, string> {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };

        public static List<string> RegularFizzBuzz(int start, int end)
        {
            if (start > end)
                (start, end) = (end, start);

            var numbers = Enumerable.Range(start, end);

            return ProcessFizzBuzz(numbers.ToArray(), defautlTokens);
        }

        public static List<string> NonSequentialFizzBuzz(int[] numbers, Dictionary<int, string>? tokens = null) => ProcessFizzBuzz(numbers, tokens ?? defautlTokens);

        private static List<string> ProcessFizzBuzz (int[] numbers, Dictionary<int, string> tokens)
        {
            var result = new List<string>();
            foreach (var number in numbers)
            {
                var multipleConcat = string.Empty;
                foreach (var item in tokens)
                {
                    if (number % item.Key == 0)
                        multipleConcat += item.Value;
                }

                if (!string.IsNullOrWhiteSpace(multipleConcat))
                    result.Add(multipleConcat);
                else
                    result.Add(number.ToString());
            }

            return result;
        }
    }
}