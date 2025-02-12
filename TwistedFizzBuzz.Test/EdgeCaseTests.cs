using TwistedFizzBuzzLib;

public class EdgeCaseTests
{
    [Fact]
    public void NonSequentialFizzBuzz_ShouldHandleEmptyInput()
    {
        // Arrange
        var numbers = new int[] { };

        // Act
        var result = TwistedFizzBuzz.NonSequentialFizzBuzz(numbers);

        // Assert
        Assert.Empty(result);
    }
}