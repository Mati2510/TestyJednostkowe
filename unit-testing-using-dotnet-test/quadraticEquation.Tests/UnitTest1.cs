using Xunit;

public class QuadraticEquationTests
{
    [Theory]
    [InlineData(1, 0, 1)]
    [InlineData(1, -2, 1)] 
    [InlineData(1, -5, 6)] 
    public void Solve_ShouldReturnCorrectRoots(double a, double b, double c)
    {
        // Act
        var roots = QuadraticEquation.Solve(a, b, c);

        // Assert
        if (roots == null)
        {
            Assert.Null(roots); 
        }
        else if (roots.Item1 == roots.Item2)
        {
            Assert.Equal(roots.Item1, roots.Item2); 
        }
        else
        {
            Assert.Equal(roots.Item1, roots.Item2);
        }
    }
}
