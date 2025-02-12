using TwistedFizzBuzzLib;

public class EdgeCaseTests
{
    [Trait("EdgeCase", "Entries that are out of the ordinary or expected")]
    [Fact(DisplayName = "Should handle empty sequence of numbers")]
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