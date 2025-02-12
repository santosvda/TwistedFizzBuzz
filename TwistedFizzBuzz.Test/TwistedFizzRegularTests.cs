using TwistedFizzBuzzLib;

public class TwistedFizzRegularTests
{
    [Fact]
    public void RegularFizzBuzz_ShouldReturnCorrectSequence()
    {
        // Arrange
        var expected = new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" };

        // Act
        var result = TwistedFizzBuzz.RegularFizzBuzz(1, 10).ToArray();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RegularFizzBuzz_ShouldHandleNegativeNumbers()
    {
        // Arrange
        var expected = new[] { "Fizz", "-2", "-1", "FizzBuzz", "1" };

        // Act
        var result = TwistedFizzBuzz.RegularFizzBuzz(-3, 1).ToArray();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RegularFizzBuzz_ShouldWorkWithNonSequential()
    {
        // Arrange
        var expected = new[] { "Fizz", "2", "Fizz", "Buzz", "Buzz" };

        // Act
        var result = TwistedFizzBuzz.NonSequentialFizzBuzz(new int[] {3, 2, 12, -40 -300, 25}).ToArray();

        // Assert
        Assert.Equal(expected, result);
    }
}