namespace TwistedFizzBuzzLib.Dto
{
    public record ApiResponseDto
    {
        public string Word { get; init; } = string.Empty;
        public int Number { get; init; }
    }
}
