using TwistedFizzBuzzLib;

public class TwistedFizzBuzzTokenTests
{
    [Fact]
    public void TwistedFizzBuzzTokens_ShouldWorkWithCustomValues()
    {
        // Arrange
        var tokens = new Dictionary<int, string> { { 7, "Foo" }, { 11, "Bar" } };
        var expected = new[] { "1", "2", "3", "4", "5", "6", "Foo", "8", "9", "10", "Bar", "12" };

        // Act
        var result = TwistedFizzBuzz.TwistedFizzBuzzTokens(1, 12, tokens).ToArray();

        // Assert
        Assert.Equal(expected, result);
    }
}