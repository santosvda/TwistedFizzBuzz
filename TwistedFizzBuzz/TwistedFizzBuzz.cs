using System.Text;
using Newtonsoft.Json;
using TwistedFizzBuzzLib.Dto;

namespace TwistedFizzBuzzLib
{
    public static class TwistedFizzBuzz
    {
        private static readonly Dictionary<int, string> defaultTokens = new()
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };

        private const string defaultEndpoint = "https://pie-healthy-swift.glitch.me";
        private static readonly HttpClient httpClient = new();

        public static IEnumerable<string> RegularFizzBuzz(int start, int end) => ProcessFizzBuzz(OrderNumbers(start, end), defaultTokens);

        public static IEnumerable<string> NonSequentialFizzBuzz(int[] numbers, Dictionary<int, string>? tokens = null) =>
            ProcessFizzBuzz(numbers, tokens ?? defaultTokens);

        public static IEnumerable<string> TwistedFizzBuzzTokens(int start, int end, Dictionary<int, string> tokens) =>
            ProcessFizzBuzz(OrderNumbers(start, end), tokens);

        public static async Task<IEnumerable<string>> ApiGeneratedTokensFizzBuzz(int start, int end, int tokensAmount = 3, string apiEndpoint = defaultEndpoint)
        {
            var tokens = new Dictionary<int, string>();
            httpClient.BaseAddress = new Uri(apiEndpoint);

            for (int i = 0; i < tokensAmount; i++)
            {
                try
                {
                    var response = await httpClient.GetAsync("word");
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();
                    var newToken = JsonConvert.DeserializeObject<ApiResponse>(json);

                    if (newToken != null)
                        tokens[newToken.Number] = newToken.Word;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"API request failed: {ex.Message}");
                }
            }

            if (!tokens.Any())
                throw new Exception("Unable to retrieve tokens from the API.");

            return ProcessFizzBuzz(OrderNumbers(start, end), tokens);
        }

        private static IEnumerable<string> ProcessFizzBuzz(int[] numbers, Dictionary<int, string> tokens)
        {
            foreach (var number in numbers)
            {
                var sb = new StringBuilder();
                foreach (var item in tokens)
                {
                    if (number % item.Key == 0)
                        sb.Append(item.Value);
                }

                yield return sb.Length > 0 ? sb.ToString() : number.ToString();
            }
        }

        private static int[] OrderNumbers(int start, int end)
        {
            if (start > end)
                (start, end) = (end, start);

            return Enumerable.Range(start, (end - start) + 1).ToArray();
        }
    }
}