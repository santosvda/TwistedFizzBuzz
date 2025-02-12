namespace TwistedFizzBuzzLib.Dto
{
    public record ApiResponse
    {
        public string Word { get; init; } = string.Empty;
        public int Number { get; init; }
    }
}
