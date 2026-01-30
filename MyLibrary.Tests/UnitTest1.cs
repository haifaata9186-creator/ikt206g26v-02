using Xunit;
using MyLibrary;

namespace MyLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        var calc = new Calculator();

        // Act
        int result = calc.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }
}
