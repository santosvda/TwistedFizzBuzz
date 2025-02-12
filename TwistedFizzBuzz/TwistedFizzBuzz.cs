using Newtonsoft.Json;
using TwistedFizzBuzzLib.Dto;

namespace TwistedFizzBuzzLib
{
    public static class TwistedFizzBuzz
    {
        private static readonly Dictionary<int, string> defautlTokens =
        new Dictionary<int, string> {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };
        private const string defaultEndpoint = "https://pie-healthy-swift.glitch.me";

        public static List<string> RegularFizzBuzz(int start, int end) => ProcessFizzBuzz(OrderNumbers(start, end), defautlTokens);

        public static List<string> NonSequentialFizzBuzz(int[] numbers, Dictionary<int, string>? tokens = null) => ProcessFizzBuzz(numbers, tokens ?? defautlTokens);

        public static List<string> TwistedFizzBuzzTokens(int start, int end, Dictionary<int, string> tokens) => ProcessFizzBuzz(OrderNumbers(start, end), tokens);

        public static async Task<List<string>> ApiGeneratedTokensFizzBuzz(int start, int end, int tokensAmount = 3, string apiEndpoint = defaultEndpoint)
        {
            Dictionary<int, string> tokens = new Dictionary<int, string>();
            ApiResponse? newToken = null;

            var http = new HttpClient{ BaseAddress = new Uri(apiEndpoint) };
            for (int i = 0; i < tokensAmount; i++)
            {
                var response = await http.GetAsync("word");
                if (response.IsSuccessStatusCode)
                    newToken = JsonConvert.DeserializeObject<ApiResponse>(await response.Content.ReadAsStringAsync());
                if (newToken is not null)
                    tokens.Add(newToken.Number, newToken.Word);

                newToken = null;
            }
            if (!tokens.Any())
                throw new Exception("Unable to connect to the API server");

            return ProcessFizzBuzz(OrderNumbers(start, end), tokens);
        }

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

        private static int[] OrderNumbers(int start, int end)
        {
            if (start > end)
                (start, end) = (end, start);

            return Enumerable.Range(start, (end - start) + 1).ToArray();
        }
    }
}