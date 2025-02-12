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

            var result = new List<string>();
            for (int i = start; i < end; i++)
            {
                var multipleConcat = string.Empty;
                foreach (var item in defautlTokens)
                {
                    if (i % item.Key == 0)
                        multipleConcat += item.Value;
                }

                if(!string.IsNullOrWhiteSpace(multipleConcat))
                    result.Add(multipleConcat);
                else
                    result.Add(i.ToString());
            }

            return result;
        }
    }
}